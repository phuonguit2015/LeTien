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

                        #region "Lương theo chức vụ"
                        XPCollection xpcLCV = new XPCollection(xpcLuongChucVu, new BinaryOperator("MucTienLuong", loaiDLTinhLuong));
                        if (xpcLCV.Count != 0)
                        {
                            ctLuong.GiaTri = (xpcLCV[0] as GiaTriTienLuongTheoChucVu).GiaTri;
                        }
                        #endregion


                        #region "Bảo Hiểm + Công Đoàn"
                        //to do
                        //if (loaiDLTinhLuong.CongThuc != null && loaiDLTinhLuong.CongThuc != string.Empty)
                        //{
                        //    string[] CongThuc = loaiDLTinhLuong.CongThuc.Split('[', ']');
                        //    decimal value = decimal.Parse(loaiDLTinhLuong.GiaTriMacDinh);
                        //    //todo lay gia tri cong thuc
                        //     XPCollection xpcvalue = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                        //    new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                        //    , new BinaryOperator("LoaiDLTinhLuong.TenLoaiDuLieu",CongThuc[1])));
                        //     decimal giatri = (xpcvalue[0] as ChiTietTienLuong).GiaTri;

                        //     if (CongThuc[2].Trim() == "*")
                        //     {
                        //         ctLuong.GiaTri = value * giatri;
                        //     }
                        //     else if (CongThuc[2].Trim() == "/")
                        //     {
                        //         ctLuong.GiaTri = value / giatri;
                        //     }
                        //     else if (CongThuc[2].Trim() == "+")
                        //     {
                        //         ctLuong.GiaTri = value + giatri;
                        //     }
                        //     else if (CongThuc[2].Trim() == "-")
                        //     {
                        //         ctLuong.GiaTri = value - giatri;
                        //     }
                        //}
                        #endregion


                        #region "Tạm ứng lương"
                        //TienTamUng
                       
                        XPCollection xpcTienTamUng = new XPCollection(xpcTamUngLuong, CriteriaOperator.Parse(
                          "NgayTamUng like '%" + ctLuong.Thang.Month + "%" + ctLuong.Thang.Year + "%' AND NhanVien! like '%"
                          + ctLuong.NhanVien + "'" ));
                        if(xpcTienTamUng.Count > 0 && loaiDLTinhLuong.TenLoaiDuLieu == "Tạm Ứng")
                        {
                            ctLuong.GiaTri = 0;
                            foreach(AdvancePayment _tienTamUng in xpcTienTamUng)
                            {
                                ctLuong.GiaTri += _tienTamUng.SoTien;
                            }

                        }
                        #endregion


                        #region "Tính lương theo công thức"
                        if (loaiDLTinhLuong.CongThuc != null && loaiDLTinhLuong.CongThuc != string.Empty)
                        {
                            string[] CongThuc = loaiDLTinhLuong.CongThuc.Split('[', ']');
                
                        
                            decimal value = decimal.Parse(loaiDLTinhLuong.GiaTriMacDinh);
                            for(int i = 2; i < CongThuc.Length - 2; i+=2)
                            {
                                XPCollection xpcvalue = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                            new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                            , new BinaryOperator("LoaiDLTinhLuong.TenLoaiDuLieu", CongThuc[i + 1])));
                                decimal giatri = (xpcvalue[0] as ChiTietTienLuong).GiaTri;
                                value = TinhToan(value, giatri, CongThuc[i]);
                            }
                            ctLuong.GiaTri = value;
                        }
                        #endregion


                        #region "Trợ cấp chuyên cần"

                        #endregion


                        #region "Tiền ăn"
                        #endregion

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


        private decimal TinhToan(decimal a, decimal b, string dau)
        {
            decimal ketqua = 0;
            if (dau.Trim() == "*")
            {
                ketqua = a * b;
            }
            else if (dau.Trim() == "/")
            {
                ketqua = a / b;
            }
            else if (dau.Trim() == "+")
            {
                ketqua = a + b;
            }
            else if (dau.Trim() == "-")
            {
                ketqua = a - b;
            }
            return ketqua;
        }
    }
}
