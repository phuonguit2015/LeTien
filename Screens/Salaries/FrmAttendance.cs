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

        public string dateVN(string enDate)
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

        public FrmAttendance(string attendanceMonth = null, string attendanceYear = null)
        {
            InitializeComponent();
            dtThang_EditValueChanged(dtThang,new EventArgs());
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
            int i = 1;
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
                    for (i = 1; i <= maxDate; i++)
                    {
                        if (i == int.Parse(s))
                        {
                            DateTime curDate = new DateTime(this.attendanceYear, this.attendanceMonth, i);
                            col.Caption = i.ToString() + " (" + dateVN(curDate.DayOfWeek.ToString()) + ")";
                            col.VisibleIndex = i + 4;
                            col.Visible = true;
                            col.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
                            col.AppearanceCell.Options.UseBackColor = false;
                            if (curDate.DayOfWeek.ToString() == "Sunday")
                            {
                                col.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
                                col.AppearanceCell.BackColor = System.Drawing.Color.Yellow;
                                col.AppearanceCell.Options.UseBackColor = true;
                            }
                            Color color = KiemTraNgayLe(xpcPublicHoliday,curDate);
                            if(color != Color.White)
                            {

                                col.AppearanceCell.BackColor = color;
                                col.AppearanceCell.Options.UseBackColor = true;
                            }
                            col.AppearanceHeader.Options.UseForeColor = true;
                            break;
                        }
                    }
                }
                if(col.FieldName.Contains("KetQua"))
                {
                    col.VisibleIndex = i + 4;
                    col.Caption = "Kết Quả";
                }
            }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //if (e.Column.Name == "DateOfMonth")
            //{
            //    GridView currentView = sender as GridView;
            //    string employeeID = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]).ToString();
            //    string employeeFName = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["first_name"]).ToString();
            //    string employeeLName = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["last_name"]).ToString();
            //    string employeeIDText = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["employee_id"]).ToString();
            //    //int date = int.Parse(e.Column.Caption.ToString());
            //    int date = e.Column.VisibleIndex - 1;

            //    string attendanceDate = this.attendanceYear.ToString() + "-" + (this.attendanceMonth < 10 ? "0" + this.attendanceMonth.ToString() : this.attendanceMonth.ToString()) + "-" + (date < 10 ? "0" + date.ToString() : date.ToString());
            //    /// string attendanceID = Objects.Attendance.GetAttendanceIdOfEmployeeByDate(employeeID, attendanceDate, session1);

            //    //Call form input attendance
            //    string frmCaption = "Chấm công nhân viên - " + employeeLName + " " + employeeLName + " (" + employeeIDText + ") ngày " + attendanceDate;
            //    SplashScreenManager.ShowForm(typeof(WaitFormMain));
            //    FrmPutAttendance frm = new FrmPutAttendance();
            //    System.Threading.Thread.Sleep(2000);
            //    frm.Text = frmCaption;
            //    frm.Show();
            //    SplashScreenManager.CloseForm();

            }
 

        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
        {
            if (e.Column.FieldName != "NhanVien.MaNhanVien" && e.Column.FieldName != "NhanVien.HoTen")
            {
                e.Merge = false;
                e.Handled = true;
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dtThang_EditValueChanged(object sender, EventArgs e)
        {
         
        }

        public void TaoBangChamCong(List<Employee> dsNV)
        {            
            DateTime date = (DateTime)dtThang.EditValue;
            CriteriaOperator criteria = new BinaryOperator("Thang", date, BinaryOperatorType.Equal);
            xpcChamCong.Filter = criteria;
            foreach (Employee e in dsNV)
            {
                foreach (LoaiDuLieuChamCong l in xpcLoaiDuLieuChamCong)
                {
                    CriteriaOperator test = CriteriaOperator.And(
                        new BinaryOperator("NhanVien", e, BinaryOperatorType.Equal),
                        new BinaryOperator("LoaiDuLieuChamCong", l, BinaryOperatorType.Equal));
                    XPCollection a = new XPCollection(xpcChamCong);
                    a.Filter = test;
                    if (a.Count == 0)
                    {
                        ChamCong chamcong = new ChamCong();
                        chamcong.NhanVien = e;
                        chamcong.LoaiDuLieuChamCong = l;
                        chamcong.Thang = date;
                        xpcChamCong.Add(chamcong);
                    }
                }
            }
            XpoDefault.Session.Save(xpcChamCong);
        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            //dtThang.EditValue = DateTime.Now;
            //dtThang.EditValueChanged += dtThang_EditValueChanged;
            gridControl1.Visible = false;
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat" || e.Column.FieldName == "KetQua") return;

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
                case "String":
                    e.RepositoryItem = txtEdit;
                    break;
            }
           

        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.RowHandle < 0) return;
            if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat" || e.Column.FieldName == "KetQua") return;
            DateTime curDate = new DateTime(attendanceYear, attendanceMonth, int.Parse(e.Column.FieldName.Substring(4)));
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
            if(_xepCa.Count > 0)
            {
                XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as XepCa).Ca),
               new BinaryOperator("LoaiDLChamCong", l)));
                if (_GTDLCCTheoCa.Count > 0)
                {


                    switch (l.LoaiChamCong)
                    {

                        case "Thời Gian Vào":
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
                                    XtraMessageBox.Show(ex.Message);
                                }

                            }
                            //So phut di tre    
                            break;
                        case "Thời Gian Ra":
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
                                    XtraMessageBox.Show(ex.Message);
                                }
                            }
                            break;
                    }
                }


            }
           
            #endregion

            #region "Màu theo ca"
            //Lấy màu của ca        
            if(e.Appearance.BackColor == Color.White && _xepCa.Count > 0)
            {
                e.Appearance.BackColor = (_xepCa[0] as XepCa).Ca.MauHienThiCa;        
            }
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
                //btnEdit.Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/edit_16x16.png");
            }
            else
            {
                gridView1.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "Đang ở chế độ chỉ đọc";
                //btnEdit.Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_16x16.png");

            }
        }

        private List<int> DanhSachNgayChuNhatTrongThang()
        {
            List<int> arr = new List<int>();
             for (int i = 1; i <= SoNgayTrongThang(); i++)
             {
                 DateTime curDate = new DateTime(this.attendanceYear, this.attendanceMonth, i);
                 if (curDate.DayOfWeek.ToString() == "Sunday")
                     arr.Add(i);
             }                            
            return arr;
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            //#region "Màu ngày chủ nhật"
            //foreach (int i in DanhSachNgayChuNhatTrongThang())
            //{
            //    string fieldName = "Ngay" + i.ToString();
            //    if (e.Column.FieldName == fieldName)
            //    {
            //        e.Appearance.BackColor = Color.YellowGreen;                    
            //    }
            //}
            //#endregion
           
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

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaoBangChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Visible = true;   
            this.attendanceMonth = DateTime.Parse(dtThang.EditValue.ToString()).Month;
            this.attendanceYear = DateTime.Parse(dtThang.EditValue.ToString()).Year;
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
     

            DateTime minDate = new DateTime(attendanceYear,attendanceMonth,1);
            DateTime maxDate = new DateTime(attendanceYear,attendanceMonth,SoNgayTrongThang());

            XPCollection _xpcXepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", minDate, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Ngay", maxDate, BinaryOperatorType.LessOrEqual)));
            if(_xpcXepCa.Count == 0)
            {
                XtraMessageBox.Show("Chưa có bảng xếp ca cho tháng này. Vui lòng tạo bảng xếp ca trước.");
                Form f = new FrmXepCa();
                f.ShowDialog();
            }
            else
            {
                List<Employee> dsNV = new List<Employee>();
                foreach(XepCa xc in _xpcXepCa)
                {
                    dsNV.Add(xc.NhanVien);
                }
                System.Threading.Thread.Sleep(1000);
                this.renderAttendanDateceColumn();
                TaoBangChamCong(dsNV);
               // gridControl1.DataSource = TaoBangChamCong(dsNV);
                //xpcChamCong = TaoBangChamCong(dsNV);
                gridView1.SortInfo.Clear();
                gridView1.SortInfo.Add(new GridColumnSortInfo(colMaNhanVien, DevExpress.Data.ColumnSortOrder.Ascending));
                gridView1.SortInfo.Add(new GridColumnSortInfo(colThoiGian, DevExpress.Data.ColumnSortOrder.Ascending));   
            }
            //Danh sach NV da xep ca trong thang thì mơi chấm công
            //
         SplashScreenManager.CloseForm();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XpoDefault.Session.Save(xpcChamCong);
        }


        private string TinhTong(ChamCong cc)
        {
            decimal _Tong = 0;
            string str = string.Empty;
            string KDLLoaiDLChamCong = cc.LoaiDuLieuChamCong.KieuDuLieu;
            str = cc.LoaiDuLieuChamCong.DonViTong == null ? string.Empty : cc.LoaiDuLieuChamCong.DonViTong;
            switch (cc.LoaiDuLieuChamCong.TinhTong)
            {
                case "Tổng":
                    if (KDLLoaiDLChamCong == "Int")
                    {
                        #region "_Tong Int"
                        _Tong += (cc.Ngay1 != null) ? decimal.Parse(cc.Ngay1) : 0;
                        _Tong += (cc.Ngay2 != null) ? decimal.Parse(cc.Ngay2) : 0;
                        _Tong += (cc.Ngay3 != null) ? decimal.Parse(cc.Ngay3) : 0;
                        _Tong += (cc.Ngay4 != null) ? decimal.Parse(cc.Ngay4) : 0;
                        _Tong += (cc.Ngay5 != null) ? decimal.Parse(cc.Ngay5) : 0;
                        _Tong += (cc.Ngay6 != null) ? decimal.Parse(cc.Ngay6) : 0;
                        _Tong += (cc.Ngay7 != null) ? decimal.Parse(cc.Ngay7) : 0;
                        _Tong += (cc.Ngay8 != null) ? decimal.Parse(cc.Ngay8) : 0;
                        _Tong += (cc.Ngay9 != null) ? decimal.Parse(cc.Ngay9) : 0;
                        _Tong += (cc.Ngay10 != null) ? decimal.Parse(cc.Ngay10) : 0;
                        _Tong += (cc.Ngay11 != null) ? decimal.Parse(cc.Ngay11) : 0;
                        _Tong += (cc.Ngay12 != null) ? decimal.Parse(cc.Ngay12) : 0;
                        _Tong += (cc.Ngay13 != null) ? decimal.Parse(cc.Ngay13) : 0;
                        _Tong += (cc.Ngay14 != null) ? decimal.Parse(cc.Ngay14) : 0;
                        _Tong += (cc.Ngay15 != null) ? decimal.Parse(cc.Ngay15) : 0;
                        _Tong += (cc.Ngay16 != null) ? decimal.Parse(cc.Ngay16) : 0;
                        _Tong += (cc.Ngay17 != null) ? decimal.Parse(cc.Ngay17) : 0;
                        _Tong += (cc.Ngay18 != null) ? decimal.Parse(cc.Ngay18) : 0;
                        _Tong += (cc.Ngay19 != null) ? decimal.Parse(cc.Ngay19) : 0;
                        _Tong += (cc.Ngay20 != null) ? decimal.Parse(cc.Ngay20) : 0;
                        _Tong += (cc.Ngay21 != null) ? decimal.Parse(cc.Ngay21) : 0;
                        _Tong += (cc.Ngay22 != null) ? decimal.Parse(cc.Ngay22) : 0;
                        _Tong += (cc.Ngay23 != null) ? decimal.Parse(cc.Ngay23) : 0;
                        _Tong += (cc.Ngay24 != null) ? decimal.Parse(cc.Ngay24) : 0;
                        _Tong += (cc.Ngay25 != null) ? decimal.Parse(cc.Ngay25) : 0;
                        _Tong += (cc.Ngay26 != null) ? decimal.Parse(cc.Ngay26) : 0;
                        _Tong += (cc.Ngay27 != null) ? decimal.Parse(cc.Ngay27) : 0;
                        _Tong += (cc.Ngay28 != null) ? decimal.Parse(cc.Ngay28) : 0;
                        _Tong += (cc.Ngay29 != null) ? decimal.Parse(cc.Ngay29) : 0;
                        _Tong += (cc.Ngay30 != null) ? decimal.Parse(cc.Ngay30) : 0;
                        _Tong += (cc.Ngay31 != null) ? decimal.Parse(cc.Ngay31) : 0;
                        #endregion
                    }
                    if (KDLLoaiDLChamCong == "DateTime")
                    {
                        #region "Tổng Số Ngày"
                        _Tong += (cc.Ngay1 != null) ? 1 : 0;
                        _Tong += (cc.Ngay2 != null) ? 1 : 0;
                        _Tong += (cc.Ngay3 != null) ? 1 : 0;
                        _Tong += (cc.Ngay4 != null) ? 1 : 0;
                        _Tong += (cc.Ngay5 != null) ? 1 : 0;
                        _Tong += (cc.Ngay6 != null) ? 1 : 0;
                        _Tong += (cc.Ngay7 != null) ? 1 : 0;
                        _Tong += (cc.Ngay8 != null) ? 1 : 0;
                        _Tong += (cc.Ngay9 != null) ? 1 : 0;
                        _Tong += (cc.Ngay10 != null) ? 1 : 0;
                        _Tong += (cc.Ngay11 != null) ? 1 : 0;
                        _Tong += (cc.Ngay12 != null) ? 1 : 0;
                        _Tong += (cc.Ngay13 != null) ? 1 : 0;
                        _Tong += (cc.Ngay14 != null) ? 1 : 0;
                        _Tong += (cc.Ngay15 != null) ? 1 : 0;
                        _Tong += (cc.Ngay16 != null) ? 1 : 0;
                        _Tong += (cc.Ngay17 != null) ? 1 : 0;
                        _Tong += (cc.Ngay18 != null) ? 1 : 0;
                        _Tong += (cc.Ngay19 != null) ? 1 : 0;
                        _Tong += (cc.Ngay20 != null) ? 1 : 0;
                        _Tong += (cc.Ngay21 != null) ? 1 : 0;
                        _Tong += (cc.Ngay22 != null) ? 1 : 0;
                        _Tong += (cc.Ngay23 != null) ? 1 : 0;
                        _Tong += (cc.Ngay24 != null) ? 1 : 0;
                        _Tong += (cc.Ngay25 != null) ? 1 : 0;
                        _Tong += (cc.Ngay26 != null) ? 1 : 0;
                        _Tong += (cc.Ngay27 != null) ? 1 : 0;
                        _Tong += (cc.Ngay28 != null) ? 1 : 0;
                        _Tong += (cc.Ngay29 != null) ? 1 : 0;
                        _Tong += (cc.Ngay30 != null) ? 1 : 0;
                        _Tong += (cc.Ngay31 != null) ? 1 : 0;
                        #endregion

                        str = "Ngày";
                    }
                    break;
                case "Tổng Dương":
                    if (KDLLoaiDLChamCong == "DateTime")
                    {
                        #region "Tổng Dương"
                        int maxDate = SoNgayTrongThang();
                        for (int i = 1; i <= maxDate; i++)
                        {
                            DateTime curDate = new DateTime(cc.Thang.Year, cc.Thang.Month, i);
                            XPCollection _xepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", curDate),
                    new BinaryOperator("NhanVien", cc.NhanVien)));
                            if (_xepCa.Count > 0 && cc[i] != null)
                            {
                                XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as XepCa).Ca),
                   new BinaryOperator("LoaiDLChamCong", cc.LoaiDuLieuChamCong)));
                                DateTime d1 = DateTime.Parse(cc[i]);
                                DateTime d2 = DateTime.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);
                                //Đi trể
                                if (SoSanhThoiGianLonHon(d1.Hour, d1.Minute, d1.Second, d2.Hour, d2.Minute, d2.Second) == true)
                                {
                                    TimeSpan t1 = new TimeSpan(d1.Hour, d1.Minute, d1.Second);
                                    TimeSpan t2 = new TimeSpan(d2.Hour, d2.Minute, d2.Second);
                                    _Tong += decimal.Parse((t1.TotalMinutes - t2.TotalMinutes).ToString());
                                }
                            }
                        }

                        #endregion

                        str = "Phút";
                    }
                    if(KDLLoaiDLChamCong == "Int")
                    {
                        #region "Tổng Dương"
                        int maxDate = SoNgayTrongThang();
                        for (int i = 1; i <= maxDate; i++)
                        {
                            DateTime curDate = new DateTime(cc.Thang.Year, cc.Thang.Month, i);
                            XPCollection _xepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", curDate),
                    new BinaryOperator("NhanVien", cc.NhanVien)));
                            if (_xepCa.Count > 0 && cc[i] != null)
                            {
                                XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as XepCa).Ca),
                   new BinaryOperator("LoaiDLChamCong", cc.LoaiDuLieuChamCong)));
                                decimal d1 = decimal.Parse(cc[i]);
                                decimal d2 = decimal.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);
                                _Tong += (d1 > d2) ? d1 - d2 : 0;
                            }
                        }

                        #endregion
                    }
                    break;
                case "Tổng Âm":
                    if (KDLLoaiDLChamCong == "DateTime")
                    {
                        #region "Tổng Âm"
                        int maxDate = SoNgayTrongThang();
                        for (int i = 1; i <= maxDate; i++)
                        {
                            DateTime curDate = new DateTime(cc.Thang.Year, cc.Thang.Month, i);
                            XPCollection _xepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", curDate),
                    new BinaryOperator("NhanVien", cc.NhanVien)));
                            if (_xepCa.Count > 0  && cc[i] != null)
                            {
                                XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as XepCa).Ca),
                   new BinaryOperator("LoaiDLChamCong", cc.LoaiDuLieuChamCong)));
                                DateTime d2 = DateTime.Parse(cc[i]);
                                DateTime d1 = DateTime.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);
                                //Về Sớm
                                if (SoSanhThoiGianLonHon(d1.Hour, d1.Minute, d1.Second, d2.Hour, d2.Minute, d2.Second) == true)
                                {
                                    TimeSpan t1 = new TimeSpan(d1.Hour, d1.Minute, d1.Second);
                                    TimeSpan t2 = new TimeSpan(d2.Hour, d2.Minute, d2.Second);
                                    _Tong += decimal.Parse((t1.TotalMinutes - t2.TotalMinutes).ToString());
                                }
                            }
                        }
                        #endregion

                        str = "Phút";
                    }
                    if (KDLLoaiDLChamCong == "Int")
                    {
                        #region "Tổng Âm"
                        int maxDate = SoNgayTrongThang();
                        for (int i = 1; i <= maxDate; i++)
                        {
                            DateTime curDate = new DateTime(cc.Thang.Year, cc.Thang.Month, i);
                            XPCollection _xepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", curDate),
                    new BinaryOperator("NhanVien", cc.NhanVien)));
                            if (_xepCa.Count > 0 && cc[i] != null)
                            {
                                XPCollection _GTDLCCTheoCa = new XPCollection(xpcGTDLCCTheoCa, CriteriaOperator.And(new BinaryOperator("Ca", (_xepCa[0] as XepCa).Ca),
                   new BinaryOperator("LoaiDLChamCong", cc.LoaiDuLieuChamCong)));
                                decimal d2 = decimal.Parse(cc[i]);
                                decimal d1 = decimal.Parse((_GTDLCCTheoCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);
                                _Tong += (d1 > d2) ? d1 - d2 : 0;
                            }
                        }

                        #endregion
                    }
                    break;
            }
            return _Tong + " " + str;
        }

        private void btnCapNhatKQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(ChamCong cc  in xpcChamCong)
            {
                cc.KetQua = TinhTong(cc).ToString();
            }
            XpoDefault.Session.Save(xpcChamCong);
            xpcChamCong.Reload();
        }

       
    
    }  
    
}
