using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using LeTien.Objects;
using LeTien.Screens;
using DevExpress.Utils;
using DevExpress.Data.Filtering;
using LeTien.Screens.List;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using LeTien.Screens.Salaries;

namespace LeTien.Screens
{
    public partial class FrmAttendance : DevExpress.XtraEditors.XtraForm
    {
        public int attendanceMonth;
        public int attendanceYear;
        DateTime firstDate = new DateTime();
        DateTime lastDate = new DateTime();

        /*public string dateVN(string enDate)
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
        }*/

        public FrmAttendance(string attendanceMonth = null, string attendanceYear = null)
        {
            InitializeComponent();

            ((System.ComponentModel.ISupportInitialize)(this.xpcLoaiDuLieuChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcPublicHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcQuanLyNgayNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcXepCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcGTDLCCTheoCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChuKyLuong)).BeginInit();

            this.xpcEmployee.ObjectType = typeof(LeTien.Objects.Employee);
            this.xpcChamCong.ObjectType = typeof(LeTien.Objects.ChamCong);
            this.xpcLoaiDuLieuChamCong.ObjectType = typeof(LeTien.Objects.LoaiDuLieuChamCong);
            this.xpcPublicHoliday.ObjectType = typeof(LeTien.Objects.PublicHoliday);
            this.xpcQuanLyNgayNghi.ObjectType = typeof(LeTien.Objects.QuanLyNgayNghi);
            this.xpcXepCa.ObjectType = typeof(LeTien.Objects.ChiTietXepCa);
            this.xpcCa.ObjectType = typeof(LeTien.Objects.DanhMucCa);
            this.xpcGTDLCCTheoCa.ObjectType = typeof(LeTien.Objects.GiaTriDuLieuChamCongTheoCa);
            this.xpcChuKyLuong.ObjectType = typeof(LeTien.Objects.ChuKyLuongThang);


            ((System.ComponentModel.ISupportInitialize)(this.xpcLoaiDuLieuChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcPublicHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcQuanLyNgayNghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcXepCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcGTDLCCTheoCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChuKyLuong)).EndInit();


            ((System.ComponentModel.ISupportInitialize)(this.xpcPhongBan)).BeginInit();
            this.xpcPhongBan.ObjectType = typeof(LeTien.Objects.PhongBan);
            ((System.ComponentModel.ISupportInitialize)(this.xpcPhongBan)).EndInit();

            dtThang.EditValue = DateTime.Now;
        }

        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
        {
            if (e.Column.FieldName != "NhanVien.MaNhanVien" && e.Column.FieldName != "NhanVien.HoTen")
            {
                e.Merge = false;
                e.Handled = true;
            }
        }
        
        private int SoNgayTrongThang()
        {
            int daysInMonth;

            DateTime now = DateTime.Now;

            if (this.attendanceMonth == 0 || this.attendanceYear == 0)
            {

                daysInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
                this.attendanceMonth = now.Month;
                this.attendanceYear = now.Year;
            }
            else
            {
                daysInMonth = System.DateTime.DaysInMonth(this.attendanceYear, this.attendanceMonth);
            }
            return daysInMonth;
        }
               
        public void renderAttendanDateceColumn()
        {
            
            int maxDate = SoNgayTrongThang();
            foreach (GridColumn col in ((ColumnView)gridControl1.Views[0]).Columns)
            {
                if (col.FieldName.Contains("Ngay"))
                {
                    string s = col.FieldName.Substring(4);
                    if (int.Parse(s) > maxDate)
                    {
                        col.Visible = false;
                        continue;
                    }
                    DateTime curDate = firstDate.AddDays(double.Parse(s) - 1);
                    //for (int i = 1; i <= maxDate; i++)
                    if(curDate <= lastDate)
                    {
                        //if (i == int.Parse(s))
                        //{
                        //DateTime curDate = new DateTime(this.attendanceYear, this.attendanceMonth, i);
                       
                        col.Caption = curDate.ToShortDateString();
                        col.OptionsColumn.AllowSort = DefaultBoolean.False;
                        //col.Caption = i.ToString() + " (" + dateVN(curDate.DayOfWeek.ToString()) + ")";
                        col.Visible = true;
                        col.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
                        col.AppearanceCell.Options.UseBackColor = false;
                        if (curDate.DayOfWeek.ToString() == "Sunday")
                        {
                            col.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
                            col.AppearanceCell.BackColor = System.Drawing.Color.Yellow;
                            col.AppearanceCell.Options.UseBackColor = true;
                        }
                        Color color = KiemTraNgayLe(xpcPublicHoliday, curDate);
                        if (color != Color.White)
                        {

                            col.AppearanceCell.BackColor = color;
                            col.AppearanceCell.Options.UseBackColor = true;
                        }
                        col.AppearanceHeader.Options.UseForeColor = true;
                        //break;
                        //}
                        
                    }
                    if(String.IsNullOrEmpty(col.Caption))
                    {
                        col.Visible = false;
                        col.VisibleIndex = -1;
                    }
                }
                if(col.FieldName.Contains("KetQua"))
                {
                    //col.VisibleIndex = i + 4;
                    col.Caption = "Kết Quả";
                }
                if (col.FieldName.Contains("Đơn Vị"))
                {
                    //col.VisibleIndex = i + 4;
                    col.Caption = "Đơn Vị";
                }
            }
        }

        private void LoadDuLieuChamCongTheoThang()
        {
            renderAttendanDateceColumn();
            if(dtThang.EditValue !=  System.DBNull.Value)
            {
                xpcChamCong.Reload();
                DateTime thang = DateTime.Parse(dtThang.EditValue.ToString());

                string str = thang.Month.ToString() + "-" + thang.Year.ToString();// Phân biệt bảng xếp ca các tháng
                XPCollection xpc = new XPCollection(xpcChamCong, 
                    CriteriaOperator.And(FilterData(),                   
                    new BinaryOperator("TenBangChamCong", str, BinaryOperatorType.Equal)));
                if (xpc.Count > 0)
                {
                    gridControl1.DataSource = xpc;
                }
                else
                {
                    XtraMessageBox.Show("Chưa có thông tin xếp ca của tháng này.", "Thông Báo");
                    gridControl1.DataSource = new DataTable();
                }
                gridView1.SortInfo.Clear();
                gridView1.SortInfo.Add(new GridColumnSortInfo(colMaNhanVien, DevExpress.Data.ColumnSortOrder.Ascending));
                gridView1.SortInfo.Add(new GridColumnSortInfo(colThoiGian, DevExpress.Data.ColumnSortOrder.Ascending));
                gridControl1.Visible = true;

            }            
        }

        private CriteriaOperator FilterData()
        {
            CriteriaOperator filter = null;
            List<CriteriaOperator> filterLoaiDL = new List<CriteriaOperator>();

          
            foreach (LoaiDuLieuChamCong item in cbbTTChamCong.Properties.Items.GetCheckedValues())
            {
                filterLoaiDL.Add(new BinaryOperator("LoaiDuLieuChamCong", item));
            } 
            if (lkupPhongBan.EditValue != null)
            {
                filter = new BinaryOperator("NhanVien.phongBan", lkupPhongBan.EditValue);            
                return CriteriaOperator.And(filter, CriteriaOperator.Or(filterLoaiDL.ToArray()));
            }
            return  CriteriaOperator.Or(filterLoaiDL.ToArray());
        }
      

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        public void TaoBangChamCong(List<Employee> dsNV)
        {            
            DateTime dt = (DateTime)dtThang.EditValue;
            DateTime minDate = new DateTime(dt.Year, dt.Month, 1);
            DateTime maxDate = new DateTime(dt.Year, dt.Month, SoNgayTrongThang());
            XPCollection _xpcChamCong = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("Thang", minDate, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Thang", maxDate, BinaryOperatorType.LessOrEqual)));
            foreach (Employee e in dsNV)
            {
                foreach (LoaiDuLieuChamCong l in xpcLoaiDuLieuChamCong)
                {
                    CriteriaOperator test = CriteriaOperator.And(
                        new BinaryOperator("NhanVien", e, BinaryOperatorType.Equal),
                        new BinaryOperator("LoaiDuLieuChamCong", l, BinaryOperatorType.Equal));
                    XPCollection a = new XPCollection(_xpcChamCong);
                    a.Filter = test;
                    if (a.Count == 0)
                    {
                        ChamCong chamcong = new ChamCong();
                        chamcong.NhanVien = e;
                        chamcong.LoaiDuLieuChamCong = l;
                        chamcong.Thang = dt;
                        xpcChamCong.Add(chamcong);
                    }
                }
            }
            XpoDefault.Session.Save(xpcChamCong);
        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            gridControl1.Visible = false;
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat" || e.Column.FieldName == "KetQua" || e.Column.FieldName == "DonVi") return;

            GridView gv = sender as GridView;
            LoaiDuLieuChamCong l = (LoaiDuLieuChamCong)gv.GetRowCellValue(e.RowHandle, gv.Columns["LoaiDuLieuChamCong!"]);
            if (l == null) return;
            switch (l.KieuDuLieu)
            {
                case "Int":
                    repositoryItemSpinEdit1.NullText = "";
                    e.RepositoryItem = repositoryItemSpinEdit1;    
                    break;
                case "DateTime":
                    e.RepositoryItem = timeEdit;
                    break;
                case "String": case "Double":
                    e.RepositoryItem = txtEdit;
                    break;
            }
           

        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.RowHandle < 0) return;
            
            if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat"|| e.Column.FieldName == "Ca" || e.Column.FieldName == "KetQua" || e.Column.FieldName == "DonVi") return;
            if (String.IsNullOrEmpty(e.Column.Caption))
                return;
            DateTime curDate = DateTime.Parse(e.Column.Caption);
            Employee nv = (Employee)gv.GetRowCellValue(e.RowHandle, gv.Columns["NhanVien!"]);

            #region "Màu ngày nghĩ"  
            XPCollection xpc = new XPCollection(xpcQuanLyNgayNghi, new BinaryOperator("NhanVien.Oid", nv.Oid));
            foreach (QuanLyNgayNghi ql in xpc)
            {
                if (curDate.CompareTo(ql.NgayBatDau) >= 0 && curDate.CompareTo(ql.NgayKetThuc) < 0)
                {
                    e.Appearance.BackColor = ql.LoaiNgayNghi.MauHienThi;
                    break;
                }
            }

            #endregion

            #region "Màu đi trể về sớm"
            string kieudulieu = gv.GetRowCellDisplayText(e.RowHandle, gv.Columns["LoaiDuLieuChamCong.LoaiChamCong"]);
            LoaiDuLieuChamCong l = (LoaiDuLieuChamCong)gv.GetRowCellValue(e.RowHandle, gv.Columns["LoaiDuLieuChamCong!"]);
            DateTime value;
            DateTime t1;
            //Tim nhan vien trong ngay do lam ca nao
            //Tim GTDLCCTheoCa thi voi ca do Loai DL CC do thì gt la bao nhieu           
            XPCollection _xepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", curDate),
                new BinaryOperator("NhanVien", nv)));
            if (_xepCa.Count > 0)
            {
                XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as ChiTietXepCa).Ca),
               new BinaryOperator("LoaiDLChamCong", l)));
                if (_GTDLCCTheoCa.Count > 0)
                {


                    switch (l.LoaiChamCong)
                    {

                        case "Giờ Vào":
                            if (gv.GetRowCellValue(e.RowHandle, e.Column) != null)
                            {
                                try
                                {
                                    t1 = DateTime.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);
                                    value = DateTime.Parse(gv.GetRowCellValue(e.RowHandle, e.Column).ToString());
                                    if (SoSanhThoiGianLonHon(((DateTime)value).Hour, ((DateTime)value).Minute, ((DateTime)value).Second, t1.Hour, t1.Minute, t1.Second) == true)
                                    {
                                        e.Appearance.BackColor = l.MauHienThiDuong;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    //XtraMessageBox.Show(ex.Message);
                                }

                            }
                            //So phut di tre    
                            break;
                        case "Giờ Ra":
                            if (gv.GetRowCellValue(e.RowHandle, e.Column) != null)
                            {
                                try
                                {
                                    t1 = DateTime.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);
                                    value = DateTime.Parse(gv.GetRowCellValue(e.RowHandle, e.Column).ToString());
                                    if (SoSanhThoiGianLonHon(((DateTime)value).Hour, ((DateTime)value).Minute, ((DateTime)value).Second, t1.Hour, t1.Minute, t1.Second) == false)
                                    {
                                        e.Appearance.BackColor = l.MauHienThiAm;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    //XtraMessageBox.Show(ex.Message);
                                }
                            }
                            break;
                    }
                }


            }
           
            #endregion

            #region "Màu theo ca"
            ////Lấy màu của ca        
            //if(e.Appearance.BackColor == Color.White && _xepCa.Count > 0)
            //{
            //    e.Appearance.BackColor = (_xepCa[0] as XepCa).Ca.MauHienThiCa;        
            //}
            #endregion    
        }
        private bool SoSanhThoiGianLonHon(int h1, int m1, int s1, int h2, int m2, int s2)
        {
            long t1 = h1 * 3600 + m1 * 60 + s1;
            long t2 = h2 * 3600 + m2 * 60 + s2;
            if (t1 > t2)
                return true;
            return false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.OptionsBehavior.ReadOnly)
            {
                btnEdit.Caption = "Đang ở chế độ chỉnh sửa";
                gridView1.OptionsBehavior.ReadOnly = false;
                foreach (GridColumn col in gridView1.Columns)
                {
                    col.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                gridView1.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "Đang ở chế độ chỉ đọc";
                foreach(GridColumn col in gridView1.Columns)
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
        }

        private Color KiemTraNgayLe(XPCollection xpc, DateTime dt)
        {
            foreach(PublicHoliday p in xpc)
            {            
                if(dt.CompareTo(p.PublicHolidayStart) >= 0 && dt.CompareTo(p.PublicHolidayEnd) < 0)
                {
                    return p.MauHienThi;
                }              
            }
            return Color.White;
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            #region "Chỉ đọc ngày nghĩ"
            if (gridView1.FocusedColumn.VisibleIndex > 2 && gridView1.FocusedColumn.VisibleIndex < 31)
            {
                Employee nv = (Employee)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["NhanVien!"]);
                DateTime dt = new DateTime(attendanceYear, attendanceMonth, int.Parse(gridView1.FocusedColumn.FieldName.Substring(4)));
                XPCollection xpc = new XPCollection(xpcQuanLyNgayNghi, new BinaryOperator("NhanVien.Oid", nv.Oid));
                foreach (QuanLyNgayNghi ql in xpc)
                {
                    if (dt.CompareTo(ql.NgayBatDau) >= 0 && dt.CompareTo(ql.NgayKetThuc) < 0)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
            #endregion
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != gridControl1) return;

            ToolTipControlInfo info = null;
            string text = string.Empty;
            object o = new object();
            //Get the view at the current mouse position
            GridView view = gridControl1.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null) return;
            //Get the view's element information that resides at the current position
            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
            //Display a hint for row indicator cells
            if (hi.HitTest == GridHitTest.RowCell)
            {
                #region "Ngày nghĩ"
                Employee nv = (Employee)gridView1.GetRowCellValue(hi.RowHandle, gridView1.Columns["NhanVien!"]);
                if (nv == null) return;

                int i;
                if (!int.TryParse(hi.Column.FieldName.Substring(4), out i)) return;
                DateTime dt = new DateTime(attendanceYear, attendanceMonth, i);
                XPCollection xpc = new XPCollection(xpcQuanLyNgayNghi, new BinaryOperator("NhanVien.Oid", nv.Oid));
                foreach (QuanLyNgayNghi ql in xpc)
                {
                    if (dt.CompareTo(ql.NgayBatDau) >= 0 && dt.CompareTo(ql.NgayKetThuc) < 0)
                    {
                        //An object that uniquely identifies a row indicator cell
                        o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                        text = ql.LoaiNgayNghi.TenNgayNghi;                        
                        break;
                    }
                }
                #endregion

                #region "Ngày lễ"
                foreach (PublicHoliday p in xpcPublicHoliday)
                {
                    if (dt.CompareTo(p.PublicHolidayStart) >= 0 && dt.CompareTo(p.PublicHolidayEnd) < 0)
                    {
                        o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                        text = p.PublicHolidayName;
                        break;
                    }
                }
                #endregion

                #region "Di trể về sớm"
                
                #endregion 

                info = new ToolTipControlInfo(o, text);
            }
            //Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
            if (info != null)
                e.Info = info;

           
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat" || e.Column.FieldName == "KetQua") return;
            ////Tổng KQ theo kiểu int    
            //decimal d = 0;
            //if (gridView1.GetRowCellDisplayText(e.RowHandle, "KetQua") != string.Empty)
            //{
            //    d = decimal.Parse(gridView1.GetRowCellDisplayText(e.RowHandle, "KetQua"));           
            //}           
            //if (gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.FocusedColumn) != null)
            //{
            //    d += decimal.Parse(gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.FocusedColumn));
            //}
            //gridView1.SetRowCellValue(e.RowHandle, "KetQua", d);

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fileName = string.Empty;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Exel 2013 (*.xls)|*.xls";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = save.FileName;
                gridControl1.ExportToXls(fileName);
            } 
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //TO DO

        }

       

        

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XpoDefault.Session.Save(xpcChamCong);
        }

        string str;
        private decimal TinhTong(ChamCong cc, int year, int month)
        {
            decimal _Tong = 0;
            str = string.Empty;

            string KDLLoaiDLChamCong = cc.LoaiDuLieuChamCong.KieuDuLieu;
            switch (cc.LoaiDuLieuChamCong.TinhTong)
            {
                case "Tổng":
                    if (KDLLoaiDLChamCong == "DateTime")
                    {
                        #region "Tổng Số Ngày"
                        if (cc.Ngay1 != "" && cc.Ngay1 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay2 != "" && cc.Ngay2 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay3 != "" && cc.Ngay3 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay4 != "" && cc.Ngay4 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay5 != "" && cc.Ngay5 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay6 != "" && cc.Ngay6 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay7 != "" && cc.Ngay7 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay8 != "" && cc.Ngay8 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay9 != "" && cc.Ngay9 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay10 != "" && cc.Ngay10 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay11 != "" && cc.Ngay11 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay12 != "" && cc.Ngay12 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay13 != "" && cc.Ngay13 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay14 != "" && cc.Ngay14 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay15 != "" && cc.Ngay15 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay16 != "" && cc.Ngay16 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay17 != "" && cc.Ngay17 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay18 != "" && cc.Ngay18 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay19 != "" && cc.Ngay19 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay20 != "" && cc.Ngay20 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay21 != "" && cc.Ngay21 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay22 != "" && cc.Ngay22 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay23 != "" && cc.Ngay23 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay24 != "" && cc.Ngay24 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay25 != "" && cc.Ngay25 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay26 != "" && cc.Ngay26 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay27 != "" && cc.Ngay27 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay28 != "" && cc.Ngay28 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay29 != "" && cc.Ngay29 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay30 != "" && cc.Ngay30 != null)
                        {
                            _Tong += 1;
                        }
                        if (cc.Ngay31 != "" && cc.Ngay31 != null)
                        {
                            _Tong += 1;
                        }
                        #endregion
                    }
                    else
                    {
                        #region "Tổng"
                        if (cc.Ngay1 != "" && cc.Ngay1 != null)
                        {
                            _Tong += (cc.Ngay1 != null) ? decimal.Parse(cc.Ngay1) : 0;
                        }
                        if (cc.Ngay2 != "" && cc.Ngay2 != null)
                        {
                            _Tong += (cc.Ngay2 != null) ? decimal.Parse(cc.Ngay2) : 0;
                        }
                        if (cc.Ngay3 != "" && cc.Ngay3 != null)
                        {
                            _Tong += (cc.Ngay3 != null) ? decimal.Parse(cc.Ngay3) : 0;
                        }
                        if (cc.Ngay4 != "" && cc.Ngay4 != null)
                        {
                            _Tong += (cc.Ngay4 != null) ? decimal.Parse(cc.Ngay4) : 0;
                        }
                        if (cc.Ngay5 != "" && cc.Ngay5 != null)
                        {
                            _Tong += (cc.Ngay5 != null) ? decimal.Parse(cc.Ngay5) : 0;
                        }
                        if (cc.Ngay6 != "" && cc.Ngay6 != null)
                        {
                            _Tong += (cc.Ngay6 != null) ? decimal.Parse(cc.Ngay6) : 0;
                        }
                        if (cc.Ngay7 != "" && cc.Ngay7 != null)
                        {
                            _Tong += (cc.Ngay7 != null) ? decimal.Parse(cc.Ngay7) : 0;
                        }
                        if (cc.Ngay8 != "" && cc.Ngay8 != null)
                        {
                            _Tong += (cc.Ngay8 != null) ? decimal.Parse(cc.Ngay8) : 0;
                        }
                        if (cc.Ngay9 != "" && cc.Ngay9 != null)
                        {
                            _Tong += (cc.Ngay9 != null) ? decimal.Parse(cc.Ngay9) : 0;
                        }
                        if (cc.Ngay10 != "" && cc.Ngay10 != null)
                        {
                            _Tong += (cc.Ngay10 != null) ? decimal.Parse(cc.Ngay10) : 0;
                        }
                        if (cc.Ngay11 != "" && cc.Ngay11 != null)
                        {
                            _Tong += (cc.Ngay11 != null) ? decimal.Parse(cc.Ngay11) : 0;
                        }
                        if (cc.Ngay12 != "" && cc.Ngay12 != null)
                        {
                            _Tong += (cc.Ngay12 != null) ? decimal.Parse(cc.Ngay12) : 0;
                        }
                        if (cc.Ngay13 != "" && cc.Ngay13 != null)
                        {
                            _Tong += (cc.Ngay13 != null) ? decimal.Parse(cc.Ngay13) : 0;
                        }
                        if (cc.Ngay14 != "" && cc.Ngay14 != null)
                        {
                            _Tong += (cc.Ngay14 != null) ? decimal.Parse(cc.Ngay14) : 0;
                        }
                        if (cc.Ngay15 != "" && cc.Ngay15 != null)
                        {
                            _Tong += (cc.Ngay15 != null) ? decimal.Parse(cc.Ngay15) : 0;
                        }
                        if (cc.Ngay16 != "" && cc.Ngay16 != null)
                        {
                            _Tong += (cc.Ngay16 != null) ? decimal.Parse(cc.Ngay16) : 0;
                        }
                        if (cc.Ngay17 != "" && cc.Ngay17 != null)
                        {
                            _Tong += (cc.Ngay17 != null) ? decimal.Parse(cc.Ngay17) : 0;
                        }
                        if (cc.Ngay18 != "" && cc.Ngay18 != null)
                        {
                            _Tong += (cc.Ngay18 != null) ? decimal.Parse(cc.Ngay18) : 0;
                        }
                        if (cc.Ngay19 != "" && cc.Ngay19 != null)
                        {
                            _Tong += (cc.Ngay19 != null) ? decimal.Parse(cc.Ngay19) : 0;
                        }
                        if (cc.Ngay20 != "" && cc.Ngay20 != null)
                        {
                            _Tong += (cc.Ngay20 != null) ? decimal.Parse(cc.Ngay20) : 0;
                        }
                        if (cc.Ngay21 != "" && cc.Ngay21 != null)
                        {
                            _Tong += (cc.Ngay21 != null) ? decimal.Parse(cc.Ngay21) : 0;
                        }
                        if (cc.Ngay22 != "" && cc.Ngay22 != null)
                        {
                            _Tong += (cc.Ngay22 != null) ? decimal.Parse(cc.Ngay22) : 0;
                        }
                        if (cc.Ngay23 != "" && cc.Ngay23 != null)
                        {
                            _Tong += (cc.Ngay23 != null) ? decimal.Parse(cc.Ngay23) : 0;
                        }
                        if (cc.Ngay24 != "" && cc.Ngay24 != null)
                        {
                            _Tong += (cc.Ngay24 != null) ? decimal.Parse(cc.Ngay24) : 0;
                        }
                        if (cc.Ngay25 != "" && cc.Ngay25 != null)
                        {
                            _Tong += (cc.Ngay25 != null) ? decimal.Parse(cc.Ngay25) : 0;
                        }
                        if (cc.Ngay26 != "" && cc.Ngay26 != null)
                        {
                            _Tong += (cc.Ngay26 != null) ? decimal.Parse(cc.Ngay26) : 0;
                        }
                        if (cc.Ngay27 != "" && cc.Ngay27 != null)
                        {
                            _Tong += (cc.Ngay27 != null) ? decimal.Parse(cc.Ngay27) : 0;
                        }
                        if (cc.Ngay28 != "" && cc.Ngay28 != null)
                        {
                            _Tong += (cc.Ngay28 != null) ? decimal.Parse(cc.Ngay28) : 0;
                        }
                        if (cc.Ngay29 != "" && cc.Ngay29 != null)
                        {
                            _Tong += (cc.Ngay29 != null) ? decimal.Parse(cc.Ngay29) : 0;
                        }
                        if (cc.Ngay30 != "" && cc.Ngay30 != null)
                        {
                            _Tong += (cc.Ngay30 != null) ? decimal.Parse(cc.Ngay30) : 0;
                        }
                        if (cc.Ngay31 != "" && cc.Ngay31 != null)
                        {
                            _Tong += (cc.Ngay31 != null) ? decimal.Parse(cc.Ngay31) : 0;
                        }
                        #endregion
                                                
                    }
                    break;
                case "Tổng Dương":
                    if (KDLLoaiDLChamCong == "DateTime")
                    {
                        #region "Tổng Đi Trể"                       


                        int maxDate = (lastDate - firstDate).Days;
                        DateTime curDate = firstDate;
                        for (int i = 1; i <= maxDate; i++)
                        {                            
                            if (curDate <= lastDate)
                            {
                                XPCollection _xepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", curDate),
                        new BinaryOperator("NhanVien", cc.NhanVien)));
                                if (_xepCa.Count > 0 && cc[i] != null)
                                {
                                    XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as ChiTietXepCa).Ca),
                       new BinaryOperator("LoaiDLChamCong.LoaiChamCong", "Giờ Vào")));
                                    if (cc[i] != "" && cc[i] != null && _GTDLCCTheoCa.Count > 0)
                                    {
                                        DateTime d1 = DateTime.Parse(cc[i]);//Giờ vào
                                        DateTime d2 = DateTime.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);//Giờ vào mặc định
                                        DateTime d3 = new DateTime(d1.Year, d1.Month, d1.Day, d2.Hour, d2.Minute, d2.Second);

                                        TimeSpan t = d3 - d1;
                                        if (t.TotalHours < 0)
                                        {
                                            _Tong += Convert.ToDecimal(-t.TotalHours);
                                        }


                                    }
                                }
                            }
                            curDate = curDate.AddDays(1);
                       
                        str = "Số Giờ Đi Trể";
                        }
                         #endregion
                    }
                    break;
                case "Tổng Âm":
                    if (KDLLoaiDLChamCong == "DateTime")
                    {
                        #region "Tổng Về Sớm"
                        int maxDate = (lastDate - firstDate).Days;
                        DateTime curDate = firstDate;
                        for (int i = 1; i <= maxDate; i++)
                        {
                            if (curDate <= lastDate)
                            {
                                XPCollection _xepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", curDate),
         new BinaryOperator("NhanVien", cc.NhanVien)));
                                if (_xepCa.Count > 0 && cc[i] != null)
                                {
                                    XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as ChiTietXepCa).Ca),
                       new BinaryOperator("LoaiDLChamCong.LoaiChamCong", "Giờ Ra")));
                                    if (cc[i] != "" && cc[i] != null && _GTDLCCTheoCa.Count > 0)
                                    {
                                        DateTime d1 = DateTime.Parse(cc[i]);//Giờ Ra
                                        DateTime d2 = DateTime.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);//Giờ vào mặc định
                                        DateTime d3 = new DateTime(d1.Year, d1.Month, d1.Day, d2.Hour, d2.Minute, d2.Second);

                                        TimeSpan t = d1 - d3;
                                        if (t.TotalHours < 0)
                                        {
                                            _Tong += Convert.ToDecimal(-t.TotalHours);
                                        }
                                    }
                                }
                            }
                            curDate = curDate.AddDays(1);

                        }


                        str = "Số Giờ Về Sớm";
                        #endregion
                    }
                    break;
            }

            str = cc.LoaiDuLieuChamCong.DonViTong == null ? str : cc.LoaiDuLieuChamCong.DonViTong;

            return _Tong;
        }

        private void btnCapNhatKQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dtThang.EditValue != System.DBNull.Value)
            {
                DateTime d = DateTime.Parse(dtThang.EditValue.ToString());

                for(int j = 0;j < xpcChamCong.Count; j++)
                {
                    ChamCong cc = xpcChamCong[j] as ChamCong;
                    cc.KetQua = String.Format("{0:0.0}", TinhTong(cc, d.Year, d.Month));
                    cc.DonVi = str;
                }
                XpoDefault.Session.Save(xpcChamCong);
                xpcChamCong.Reload();
            }
            Cursor = Cursors.Default;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }


        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {

        }

        private void gridView1_RowCellClick_1(object sender, RowCellClickEventArgs e)
        {
             if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat" || e.Column.FieldName == "KetQua") return;
             if (e.Clicks >= 2)
             {

                 DateTime d = DateTime.Parse(dtThang.EditValue.ToString());
                 DateTime dt = new DateTime(d.Year, d.Month, int.Parse(e.Column.FieldName.Substring(4)));
                 Employee nv = (gridView1.GetRowCellValue(e.RowHandle, colNhanVien)) as Employee;
                 e.Handled = true;
                 if (nv == null)
                     return;
                 Form f = new FrmPhieuChamCong(nv, dt);
                 f.ShowDialog();
             }
            
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = new FrmImportChamCong();
            f.ShowDialog();
        }

        private void btnCapNhatDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(firstDate == new DateTime() || lastDate == new DateTime())
            {
                XtraMessageBox.Show("Tháng bạn chọn chưa có thông tin.", "THÔNG BÁO");
                return;
            }
            LoadDuLieuChamCongTheoThang();
        }

        private void dtThang_EditValueChanged_1(object sender, EventArgs e)
        {
            DateTime d = DateTime.Parse(dtThang.EditValue.ToString());
            attendanceMonth = d.Month;
            attendanceYear = d.Year;
            DateTime minDate = new DateTime(d.Year, d.Month, 1);
            DateTime maxDate = new DateTime(d.Year, d.Month, SoNgayTrongThang());

            XPCollection xpc = new XPCollection(xpcChuKyLuong, CriteriaOperator.And(new BinaryOperator("Thang", minDate,
                BinaryOperatorType.GreaterOrEqual), new BinaryOperator("Thang", maxDate, BinaryOperatorType.LessOrEqual)));
            if (xpc.Count > 0)
            {
                firstDate = (xpc[0] as ChuKyLuongThang).FirstDate;
                lastDate = (xpc[0] as ChuKyLuongThang).LastDate;

            }
            else
            {
                firstDate = new DateTime();
                lastDate = new DateTime();
            }

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDuLieuChamCongTheoThang();
        }
    
    }  
    
}
