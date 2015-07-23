using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using LeTien.Objects;
using LeTien.Screens.List;
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
    public partial class FrmXepCa : FormBase
    {
        public FrmXepCa()
        {
            InitializeComponent();            
        }


        #region "Override FromBase"
        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                Employee nv = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", grvUCList.GetRowCellValue(grvUCList.FocusedRowHandle, colMaNhanVien).ToString()));
                DateTime dt = new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1);
                DateTime minDate = new DateTime(dt.Year, dt.Month, 1);
                DateTime maxDate = new DateTime(dt.Year, dt.Month, SoNgayTrongThang(dt.Month, dt.Year));
               
                XPCollection _xpcXepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Thang", minDate, BinaryOperatorType.GreaterOrEqual),
            new BinaryOperator("Thang", maxDate, BinaryOperatorType.LessOrEqual)));
                XPCollection _xepCa = new XPCollection(_xpcXepCa, new BinaryOperator("NhanVien", nv));
                foreach (XepCa br in _xepCa)
                {
                    if (br != null)
                    {
                        br.Delete();

                    }
                }
                uow.CommitChanges();
                uow.PurgeDeletedObjects();
                RefreshData();
            }
        }
        protected override void OnReload()
        {
            UOW.ReloadChangedObjects();
            xpcXepCa.Reload();
            HienThiDanhSachTheoThang(new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1));
        }


        #endregion




        public void RefreshData()
        {
            OnReload();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnPreview(gridUCList, "DANH SÁCH XẾP CA", "reportTemplate.repx");

        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls(gridUCList);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnTaoBangXepCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaoBangXepCa();
        }
        public void TaoBangXepCa()
        {
            List<Employee> dsNV = new List<Employee>();
            foreach (Employee nv in xpcNhanVien)
            {
                dsNV.Add(nv);
            }
            //Kiểm tra xem tháng này đã có xếp ca chưa
            DateTime dt = new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1);
            DateTime minDate = new DateTime(dt.Year, dt.Month, 1);
            DateTime maxDate = new DateTime(dt.Year, dt.Month, SoNgayTrongThang(dt.Month, dt.Year));
            XPCollection _xpcXepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Thang", minDate, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Thang", maxDate, BinaryOperatorType.LessOrEqual)));
            if(_xpcXepCa.Count == 0)
            {
                if(XtraMessageBox.Show("Tháng này chưa có bảng xếp ca. Bạn có muốn tạo bảng xếp ca mới không?", "Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {

                    Form f = new FrmXepCaTuDong(dsNV,dt);
                    if(f.ShowDialog() == DialogResult.Cancel)
                    {
                        HienThiDanhSachTheoThang(new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1));
                    }
                }
            }
        }
    
        private void HienThiDanhSachTheoThang(DateTime dt)
        {
            DateTime minDate = new DateTime(dt.Year, dt.Month, 1);
            DateTime maxDate = new DateTime(dt.Year, dt.Month, SoNgayTrongThang(dt.Month, dt.Year));

            renderAttendanDateceColumn(dt.Month, dt.Year);
            xpcXepCa.Reload();
            XPCollection _xpcXepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Thang", minDate, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Thang", maxDate, BinaryOperatorType.LessOrEqual)));
            gridUCList.DataSource = _xpcXepCa;
        }

        private void dtItemThang_EditValueChanged(object sender, EventArgs e)
        {

        }
       

        private void FrmXepCa_Load(object sender, EventArgs e)
        {
            spinThang.EditValue = DateTime.Now.Month;
            spinNam.EditValue = DateTime.Now.Year;         

            //renderAttendanDateceColumn(int.Parse(spinThang.EditValue.ToString()), int.Parse(spinNam.EditValue.ToString()));
            HienThiDanhSachTheoThang(new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1));
            LayDanhMucCa();
        }



        //Tạo cột stt
        private void grvUCList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        //Tạo cấu trúc các cột ngày  cho gridcontrol
        public void renderAttendanDateceColumn(int month, int year)
        {
            foreach (GridColumn col in ((ColumnView)gridUCList.Views[0]).Columns)
            {
                if (col.FieldName.Contains("Ngay"))
                {
                    string s = col.FieldName.Substring(4);                 
                    if (int.Parse(s) <= SoNgayTrongThang(month, year))
                    {
                        DateTime dt = new DateTime(year, month, int.Parse(s));
                        col.Caption = s + " (" + dateVN(dt.DayOfWeek.ToString()) + ")";
                        col.OptionsColumn.FixedWidth = true;
                        col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        col.Width = 80;
                        col.ColumnEdit = lkupCa;
                        col.Visible = true;
                        col.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
                        col.AppearanceCell.Options.UseBackColor = false;
                        if (dt.DayOfWeek.ToString() == "Sunday")
                        {
                            col.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
                            col.AppearanceCell.Options.UseBackColor = true;
                        }
                    }
                    else
                    {
                        col.Visible = false;
                    }
                }
            }
        }
        //Lấy số ngày trong tháng
        private int SoNgayTrongThang(int month, int year)
        {
            int daysInMonth;

            DateTime now = DateTime.Now;

            if (month == 0 || year == 0)
            {

                daysInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
            }
            else
            {
                daysInMonth = System.DateTime.DaysInMonth(year, month);
            }
            return daysInMonth;
        }
        //Lấy ngày việt nam
        private string dateVN(string enDate)
        {
            string strReturn;

            switch (enDate)
            {
                case "Monday":
                    strReturn = "THai";
                    break;
                case "Tuesday":
                    strReturn = "TBa";
                    break;
                case "Wednesday":
                    strReturn = "TTư";
                    break;
                case "Thursday":
                    strReturn = "TNăm";
                    break;
                case "Friday":
                    strReturn = "TSáu";
                    break;
                case "Saturday":
                    strReturn = "TBảy";
                    break;
                case "Sunday":
                default:
                    strReturn = "CN";
                    break;
            }

            return strReturn;
        }      
     

        private void btnCaLamViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = new FrmDanhMucCa();
            f.ShowDialog();
        }

        private void grvUCList_CellMerge(object sender, CellMergeEventArgs e)
        {
            if (e.Column.FieldName != "NhanVien.MaNhanVien" && e.Column.FieldName != "NhanVien.HoTen")
            {
                e.Merge = false;
                e.Handled = true;
            }

        }


        //Luu thong tin cham cong
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        //Lay thong tin nhan vien theo ma nhan vien
        private Employee GetEmployee(string maNhanVien)
        {
            XPCollection xpcNV = new XPCollection(xpcNhanVien, new BinaryOperator("MaNhanVien", maNhanVien, BinaryOperatorType.Equal));
            if(xpcNV.Count == 0)
                return null;
            return xpcNV[0] as Employee;
        }
        //Lay thong tin ca theo ten ca
        private DanhMucCa GetShift(string tenCa)
        {
            XPCollection _xpcCa = new XPCollection(xpcCa, new BinaryOperator("TenCa", tenCa, BinaryOperatorType.Equal));
            if (_xpcCa.Count == 0)
                return null;
            return _xpcCa[0] as DanhMucCa;
        }

        private void grvUCList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }
       

        private void spinThang_EditValueChanged(object sender, EventArgs e)
        {
            if (spinNam.EditValue == null || spinThang.EditValue == null)
                return;
            HienThiDanhSachTheoThang(new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1));
            if(grvUCList.RowCount == 0)
            {
                if (XtraMessageBox.Show("Chưa có dữ liệu bảng xếp ca! Bạn có muốn tạo bảng xếp ca cho tháng này?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    TaoBangXepCa();
                }
            }
        }

        private void spinNam_EditValueChanged(object sender, EventArgs e)
        {
            if (spinNam.EditValue == null || spinThang.EditValue == null)
                return;
            HienThiDanhSachTheoThang(new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1));
            if (grvUCList.RowCount == 0)
            {
                if (XtraMessageBox.Show("Chưa có dữ liệu bảng xếp ca! Bạn có muốn tạo bảng xếp ca cho tháng này?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    TaoBangXepCa();
                }
            }
        }

        private void LayDanhMucCa()
        {
            lkupCa.DataSource = xpcCa;
            lkupCa.ValueMember = "Oid";
            lkupCa.DisplayMember = "TenCa";

            lkupDanhSachCa.Properties.DataSource = xpcCa;
            lkupDanhSachCa.Properties.ValueMember = "Oid";
            lkupDanhSachCa.Properties.DisplayMember = "TenCa";
        }


        private List<Employee> DanhSachNhanVienChuaXepCa()
        {
            listNhanVien.Items.Clear();
            List<Employee> list = new List<Employee>();
            DateTime dt = new DateTime(int.Parse(spinNam.EditValue.ToString()), int.Parse(spinThang.EditValue.ToString()), 1);
            DateTime minDate = new DateTime(dt.Year, dt.Month, 1);
            DateTime maxDate = new DateTime(dt.Year, dt.Month, SoNgayTrongThang(dt.Month, dt.Year));
            XPCollection xpcNhanVienXepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Thang", DateTime.Parse(dtTuNgay.EditValue.ToString()), BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Thang", DateTime.Parse(dtDenNgay.EditValue.ToString()), BinaryOperatorType.LessOrEqual)));
            if (xpcNhanVienXepCa.Count > 0)
            {
                //Lấy tất cả nhân viên chưa xếp ca
                XPCollection xpcNhanVienCTietXepCa = new XPCollection(xpcChiTietXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", DateTime.Parse(dtTuNgay.EditValue.ToString()), BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Ngay", DateTime.Parse(dtDenNgay.EditValue.ToString()), BinaryOperatorType.LessOrEqual)));
                if (xpcNhanVienCTietXepCa.Count > 0)
                {
                    foreach (Employee nv in xpcNhanVien)
                    {
                        foreach (ChiTietXepCa ctXepCa in xpcNhanVienCTietXepCa)
                        {
                            //Hiển thị thông tin nhân viên chưa có ca trog thời gian này
                            //Nếu nhân viên đã có ca thì thêm một thông tin những ngày có ca
                            //Thực hiện thao tác có ghi đè thông tin ca đã tồn tại hay không?

                            if (nv.Oid != ctXepCa.NhanVien.Oid)
                            {
                                list.Add(nv);
                                listNhanVien.Items.Add(nv.HoTen);
                            }
                        }
                    }
                    return list;
                }
            }

            foreach (Employee nv in xpcNhanVien)
            {
                list.Add(nv);
                listNhanVien.Items.Add(nv.HoTen);
            }
            
            return list;
        }


        private void btnXepCaTuDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXepCa_Click(object sender, EventArgs e)
        {

        }

        private void btnLocDanhSach_Click(object sender, EventArgs e)
        {
            DanhSachNhanVienChuaXepCa();
        }

    }
}
