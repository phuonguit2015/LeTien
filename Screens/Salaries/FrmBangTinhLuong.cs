using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LeTien.Objects;
using Microsoft.JScript;
using Microsoft.JScript.Vsa;
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

            ((System.ComponentModel.ISupportInitialize)(this.xpcGiaTriTienLuongTheoChucVu)).BeginInit();
            this.xpcGiaTriTienLuongTheoChucVu.ObjectType = typeof(LeTien.Objects.GiaTriTienLuongTheoChucVu);
            ((System.ComponentModel.ISupportInitialize)(this.xpcGiaTriTienLuongTheoChucVu)).EndInit();
        }

        private void btnLoaiDuLieuTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLoaiDuLieuTinhLuong f = new FrmLoaiDuLieuTinhLuong();
            f.ShowDialog();
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Lấy bảng chấm công theo tháng cần tính lương
            if (dtThang.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn tháng.", "THÔNG BÁO");
                return;
            }
            TaoDuLieuTinhLuongThang();
            //TinhLuongTheoCongThuc();
        }


        private void TaoDuLieuTinhLuongThang()
        {
            XPCollection xpcLuongChucVu = new XPCollection(typeof(GiaTriTienLuongTheoChucVu));
            if (xpcLuongChucVu.Count == 0)
            {
                XtraMessageBox.Show("Chưa có dữ liệu lương chức vụ. Vui lòng khởi tạo dữ liệu lương chức vụ.");
                return;
            }
           
            xpcChamCong.Reload();
            DateTime thang = DateTime.Parse(dtThang.EditValue.ToString());

            string str = thang.Month.ToString() + "-" + thang.Year.ToString();// Phân biệt bảng xếp ca các tháng
            XPCollection xpcChamCongTheoThang = new XPCollection(xpcChamCong, new BinaryOperator("TenBangChamCong", str, BinaryOperatorType.Equal));

            if (xpcChamCongTheoThang.Count > 0)
            {
                xpcMucTienLuong.Sorting = new SortingCollection(new SortProperty[]{
                    new SortProperty("UuTien",DevExpress.Xpo.DB.SortingDirection.Ascending)});
                foreach (Employee item in xpcNhanVien)
                {
                    foreach (LoaiDuLieuTinhLuong loaiDL in xpcMucTienLuong)
                    {
                        /*ChiTietTienLuong ctLuong = new ChiTietTienLuong()
                        {
                            NhanVien = item,
                            Thang = DateTime.Parse(dtThang.EditValue.ToString()),
                            LoaiDLTinhLuong = loaiDL,
                            GiaTri = 0
                        };
                        if(!String.IsNullOrEmpty(loaiDL.GiaTriMacDinh))
                        {
                            ctLuong.GiaTri = decimal.Parse(loaiDL.GiaTriMacDinh);
                        }
                        //Kiểm tra chi tiết lương đã có chưa
                        XPCollection xpc = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                          new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                          , new BinaryOperator("LoaiDLTinhLuong", ctLuong.LoaiDLTinhLuong)));
                        if (xpc.Count == 0)
                        {
                            xpcChiTietLuong.Add(ctLuong);
                        }
                        else
                        {
                            ChiTietTienLuong ctTemp = xpc[0] as ChiTietTienLuong;
                            ctTemp.GiaTri = ctLuong.GiaTri;//?
                        }*/



                        ChiTietTienLuong ctLuong = new ChiTietTienLuong()
                        {
                            NhanVien = item,
                            Thang = DateTime.Parse(dtThang.EditValue.ToString()),
                            LoaiDLTinhLuong = loaiDL,
                            GiaTri = 0
                        };
                        //Tinh Theo Gia Tri Mac Dinh
                        if(!String.IsNullOrEmpty(loaiDL.GiaTriMacDinh))
                        {
                            ctLuong.GiaTri = decimal.Parse(loaiDL.GiaTriMacDinh);
                        }

                        //Tinh Theo Chuc Vu
                        #region TÍNH LƯƠNG THEO CHỨC VỤ
                        if (ctLuong.LoaiDLTinhLuong.NhomChucVu)
                        {

                            XPCollection xpcGiaTriTheoChucVu = new XPCollection(xpcGiaTriTienLuongTheoChucVu, CriteriaOperator.And(new BinaryOperator("ChucVu", ctLuong.NhanVien.ChucVu),
                                    new BinaryOperator("MucTienLuong", ctLuong.LoaiDLTinhLuong)));
                            if (xpcGiaTriTheoChucVu.Count > 0)
                            {
                                GiaTriTienLuongTheoChucVu gtLuongTheoChucVu = xpcGiaTriTheoChucVu[0] as GiaTriTienLuongTheoChucVu;
                                ctLuong.GiaTri = gtLuongTheoChucVu.GiaTri == null ? 0 : gtLuongTheoChucVu.GiaTri;

                            }
                        }
                        #endregion

                        //Tinh luong theo cong thuc
                         #region TÍNH LƯƠNG THEO CÔNG THỨC
                        using (var uow = new UnitOfWork())
                        {
                            LoaiDuLieuTinhLuong temp = uow.FindObject<LoaiDuLieuTinhLuong>(CriteriaOperator.Parse("Oid = ?", ctLuong.LoaiDLTinhLuong.Oid));
                            //Kiểm tra xem loại dữ liệu tính lương này có sử dụng công thức không
                            if (!String.IsNullOrEmpty(temp.CongThuc))
                            {
                                //Công thức được định dạng chuẩn:
                                /* Cột lưu [C+số thứ tự] : C tiền tớ bắt buộc
                                   Giá trị [Giá Trị]
                                 VD: [C3] + [C5] * [100]*/

                                string[] congThuc = temp.CongThuc.Split('[', ']'); // "", C3, +, C10, *, 100, "" 8+10*100
                                string bieuthuc = string.Empty;
                                for (int j = 1; j < congThuc.Length; j++)
                                {
                                    if (congThuc[j].Contains('C'))
                                    {
                                        XPCollection xpcGiatri = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                                    new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                                    , new BinaryOperator("LoaiDLTinhLuong.STT", congThuc[j].Substring(1))));
                                        if (xpcGiatri.Count > 0)
                                        {                                      
                                            decimal temp1 = (xpcGiatri[0] as ChiTietTienLuong).GiaTri;
                                            bieuthuc += temp1;
                                        }
                                    }
                                    else
                                    {
                                        if (congThuc[j] != "")
                                        {
                                            bieuthuc += congThuc[j];
                                        }
                                    }
                                }
                                ctLuong.GiaTri = TinhBieuThucDonGian(bieuthuc);
                            }
                        }
                         #endregion


                        //Kiểm tra chi tiết lương đã có chưa
                        XPCollection xpc = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                          new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                          , new BinaryOperator("LoaiDLTinhLuong", ctLuong.LoaiDLTinhLuong)));
                        if (xpc.Count == 0)
                        {
                            xpcChiTietLuong.Add(ctLuong);
                        }
                        else
                        {
                            ChiTietTienLuong ctTemp = xpc[0] as ChiTietTienLuong;
                            ctTemp.GiaTri = ctLuong.GiaTri;//?
                        }
                    }
                }
            }
            XpoDefault.Session.Save(xpcChiTietLuong);
            pivotGridControl1.RefreshData();        
        }


        

        private void TinhLuongTheoCongThuc()
        {
            for(int i = 0; i < xpcChiTietLuong.Count; i++)
            {
                ChiTietTienLuong ctLuong = xpcChiTietLuong[i] as ChiTietTienLuong;

                #region TÍNH LƯƠNG THEO CÔNG THỨC
                using (var uow = new UnitOfWork())
                {                    
                    LoaiDuLieuTinhLuong temp = uow.FindObject<LoaiDuLieuTinhLuong>(CriteriaOperator.Parse("Oid = ?", ctLuong.LoaiDLTinhLuong.Oid));
                    //Kiểm tra xem loại dữ liệu tính lương này có sử dụng công thức không
                    if (!String.IsNullOrEmpty(temp.CongThuc))
                    {
                        //Công thức được định dạng chuẩn:
                        /* Cột lưu [C+số thứ tự] : C tiền tớ bắt buộc
                           Giá trị [Giá Trị]
                         VD: [C3] + [C5] * [100]*/


                        string[] congThuc = temp.CongThuc.Split('[', ']'); // "", C3, +, C10, *, 100, "" 8+10*100
                        string bieuthuc = string.Empty;
                        for (int j = 1; j < congThuc.Length; j++)
                        {
                            if (congThuc[j].Contains('C'))
                            {
                                XPCollection xpcGiatri = new XPCollection(xpcChiTietLuong, CriteriaOperator.And(
                            new BinaryOperator("Thang", ctLuong.Thang), new BinaryOperator("NhanVien", ctLuong.NhanVien)
                            , new BinaryOperator("LoaiDLTinhLuong.STT", congThuc[j].Substring(1))));
                                if (xpcGiatri.Count > 0)
                                {
                                    ChiTietTienLuong cttl = xpcGiatri[0] as ChiTietTienLuong; 
                                    if(cttl.LoaiDLTinhLuong.CongThuc.Contains('['))
                                    {

                                    }
                                    decimal temp1 = (xpcGiatri[0] as ChiTietTienLuong).GiaTri;
                                    bieuthuc += temp1;
                                }
                            }
                            else
                            {
                                if(congThuc[j] != "")
                                {
                                    bieuthuc += congThuc[j];
                                }
                            }
                        }                        
                        ctLuong.GiaTri = TinhBieuThucDonGian(bieuthuc);

                    }
                }
                #endregion

                #region TÍNH LƯƠNG THEO CHỨC VỤ
                if (ctLuong.LoaiDLTinhLuong.NhomChucVu)
                {

                    XPCollection xpcGiaTriTheoChucVu = new XPCollection(xpcGiaTriTienLuongTheoChucVu, CriteriaOperator.And(new BinaryOperator("ChucVu", ctLuong.NhanVien.ChucVu),
                            new BinaryOperator("MucTienLuong", ctLuong.LoaiDLTinhLuong)));
                    if (xpcGiaTriTheoChucVu.Count > 0)
                    {
                        GiaTriTienLuongTheoChucVu gtLuongTheoChucVu = xpcGiaTriTheoChucVu[0] as GiaTriTienLuongTheoChucVu;
                        ctLuong.GiaTri = gtLuongTheoChucVu.GiaTri == null ? 0 : gtLuongTheoChucVu.GiaTri;

                    }
                }
                #endregion
            }
            XpoDefault.Session.Save(xpcChiTietLuong);
            pivotGridControl1.RefreshData();
        }

        private decimal TinhBieuThucDonGian(string bieuthuc)
        {
            VsaEngine vsaEngine = VsaEngine.CreateEngine();
            return decimal.Parse(Eval.JScriptEvaluate(bieuthuc, vsaEngine).ToString());
        }

       
       

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            xpcChiTietLuong.Reload();
            pivotGridControl1.DataSource = xpcChiTietLuong;
        }

        private void btnTinhLuong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Lấy bảng chấm công theo tháng cần tính lương
            if (dtThang.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn tháng.", "THÔNG BÁO");
                return;
            }
            TinhLuongTheoCongThuc();
            XtraMessageBox.Show("Tính toán thông tin lương thành công...", "THÔNG BÁO");
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fileName = string.Empty;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Exel 2013 (*.xls)|*.xls";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = save.FileName;
                pivotGridControl1.ExportToXls(fileName);
            }      
        }
    }
}
