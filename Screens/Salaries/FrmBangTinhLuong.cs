using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LeTien.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.Salaries
{
    public partial class FrmBangTinhLuong : Form
    {
        public FrmBangTinhLuong()
        {
            InitializeComponent();
        }

        private void btnLoaiDuLieuTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLoaiDuLieuTinhLuong f = new FrmLoaiDuLieuTinhLuong();
            f.ShowDialog();
        }

        private void KhoiTaoDuLieuTinhLuong()
        {
            //XPCollection xpcChamCong = new XPCollection(typeof(ChamCong),);
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(dtThang.EditValue != null)
            {
                XPCollection xpcChamCong = new XPCollection(typeof(ChamCong), new BinaryOperator ("Thang",dtThang.EditValue));
                if (xpcChamCong.Count == 0)
                {
                    XtraMessageBox.Show("Chưa có dữ liệu chấm công. Vui lòng khởi tạo dữ liệu chấm công.");
                    return;
                }
                XPCollection xpcLuongChucVu = new XPCollection(typeof(GiaTriTienLuongTheoChucVu));
                if (xpcLuongChucVu.Count == 0)
                {
                    XtraMessageBox.Show("Chưa có dữ liệu lương chức vụ. Vui lòng khởi tạo dữ liệu lương chức vụ.");
                    return;
                }
               
                foreach(Employee nv in xpcNhanVien)
                {
                    foreach (LoaiDuLieuTinhLuong loaiDLTinhLuong in xpcMucTienLuong)
                    {
                        ChiTietTienLuong ctLuong = new ChiTietTienLuong()
                        {
                            Thang = DateTime.Parse(dtThang.EditValue.ToString()),
                            NhanVien = nv,
                            LoaiDLTinhLuong = loaiDLTinhLuong
                        };
                        XPCollection xpcLCV = new XPCollection(xpcLuongChucVu, new BinaryOperator("MucTienLuong", loaiDLTinhLuong));
                        if (xpcLCV.Count != 0)
                        {
                            ctLuong.GiaTri = (xpcLCV[0] as GiaTriTienLuongTheoChucVu).GiaTri;
                        }
                        //to do
                        if (loaiDLTinhLuong.CongThuc != null && loaiDLTinhLuong.CongThuc != string.Empty)
                        {
                            string[] CongThuc = loaiDLTinhLuong.CongThuc.Split('[', ']');
                            decimal value = decimal.Parse(loaiDLTinhLuong.GiaTriMacDinh);
                            //todo lay gia tri cong thuc
                             XPCollection xpcvalue = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                            new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                            , new BinaryOperator("LoaiDLTinhLuong.TenLoaiDuLieu",CongThuc[1] )));
                             decimal giatri = (xpcvalue[0] as ChiTietTienLuong).GiaTri;
                            if(CongThuc[2].Trim() == "*")
                            {
                                ctLuong.GiaTri = value * giatri;
                            }
                            else if (CongThuc[2].Trim() == "/")
                            {
                                ctLuong.GiaTri = value / giatri;
                            }
                            else if(CongThuc[2].Trim() == "+")
                            {
                                ctLuong.GiaTri = value + giatri;
                            }
                            else if (CongThuc[2].Trim() == "-")
                            {
                                ctLuong.GiaTri = value - giatri;
                            }
                        }
                        XPCollection xpc = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                            new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                            , new BinaryOperator("LoaiDLTinhLuong", ctLuong.LoaiDLTinhLuong)));
                        if (xpc.Count == 0)
                        {
                            xpcChiTietLuong.Add(ctLuong);
                        }
                    }

                }
                XpoDefault.Session.Save(xpcChiTietLuong);
                pivotGridControl1.RefreshData();
            }
        }

    }
}
