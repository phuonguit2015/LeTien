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
            foreach (GridColumn col in ((ColumnView)gridControl1.Views[0]).Columns)
            {
                if (col.FieldName.Contains("Ngay"))
                {
                    string s = col.FieldName.Substring(4);
                    if (int.Parse(s) > SoNgayTrongThang())
                    {
                        col.Visible = false;
                        continue;
                    }
                    for (int i = 1; i <= SoNgayTrongThang(); i++)
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
           // SplashScreenManager.ShowForm(typeof(WaitFormMain));
            this.attendanceMonth = DateTime.Parse(dtThang.EditValue.ToString()).Month;
            this.attendanceYear = DateTime.Parse(dtThang.EditValue.ToString()).Year;

            System.Threading.Thread.Sleep(2000);
            this.renderAttendanDateceColumn();
            gridControl1.DataSource = TaoBangChamCong();
            gridView1.SortInfo.Clear();
            gridView1.SortInfo.Add(new GridColumnSortInfo(colMaNhanVien, DevExpress.Data.ColumnSortOrder.Ascending));
            gridView1.SortInfo.Add(new GridColumnSortInfo(colThoiGian, DevExpress.Data.ColumnSortOrder.Ascending));
            //SplashScreenManager.CloseForm();
        }

        public XPCollection TaoBangChamCong()
        {
            XPCollection xpc = new XPCollection(typeof(ChamCong));
            DateTime date = (DateTime)dtThang.EditValue;
            CriteriaOperator criteria = new BinaryOperator("Thang", date, BinaryOperatorType.Equal);
            xpc.Filter = criteria;
            foreach (Employee e in xpcEmployee)
            {
                foreach (LoaiDuLieuChamCong l in xpcLoaiDuLieuChamCong)
                {
                    CriteriaOperator test = CriteriaOperator.And(
                        new BinaryOperator("NhanVien", e, BinaryOperatorType.Equal),
                        new BinaryOperator("LoaiDuLieuChamCong", l, BinaryOperatorType.Equal));
                    XPCollection a = new XPCollection(xpc);
                    a.Filter = test;
                    if (a.Count == 0)
                    {
                        ChamCong chamcong = new ChamCong();
                        chamcong.NhanVien = e;
                        chamcong.LoaiDuLieuChamCong = l;
                        chamcong.Thang = date;
                        xpc.Add(chamcong);
                    }
                }
            }
            XpoDefault.Session.Save(xpc);
            return xpc;
        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            dtThang.EditValue = DateTime.Now;
            dtThang.EditValueChanged += dtThang_EditValueChanged;
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat") return;

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
       
            #region "Màu ngày nghĩ"            
            Employee nv = (Employee)gv.GetRowCellValue(e.RowHandle, gv.Columns["NhanVien!"]);
            DateTime dt = new DateTime(attendanceYear, attendanceMonth, int.Parse(e.Column.FieldName.Substring(4)));
            XPCollection xpc = new XPCollection(xpcQuanLyNgayNghi, new BinaryOperator("NhanVien.Oid", nv.Oid));
            foreach (QuanLyNgayNghi ql in xpc)
            {
                if (dt.CompareTo(ql.NgayBatDau) >= 0 && dt.CompareTo(ql.NgayKetThuc) < 0)
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
            switch (l.LoaiChamCong)
            {

                case "Thời Gian Vào":
                    if (gv.GetRowCellValue(e.RowHandle, e.Column) != null)
                    {
                        t1 = DateTime.Parse(l.DuLieuMacDinh);
                        value = DateTime.Parse(gv.GetRowCellValue(e.RowHandle, e.Column).ToString());
                        if (SoSanhThoiGian(((DateTime)value).Hour, ((DateTime)value).Minute, ((DateTime)value).Second, t1.Hour, t1.Minute, t1.Second) == true)
                        {
                            e.Appearance.BackColor = l.MauHienThiDuong;
                        }
                    }
                    //So phut di tre    
                    break;
                case "Thời Gian Ra":
                    if (gv.GetRowCellValue(e.RowHandle, e.Column) != null)
                    {
                        t1 = DateTime.Parse(l.DuLieuMacDinh);
                        value = DateTime.Parse(gv.GetRowCellValue(e.RowHandle, e.Column).ToString());
                        if (SoSanhThoiGian(((DateTime)value).Hour, ((DateTime)value).Minute, ((DateTime)value).Second, t1.Hour, t1.Minute, t1.Second) == false)
                        {
                            e.Appearance.BackColor = l.MauHienThiAm;
                        }
                    }
                    break;
            }


            #endregion

        }
        private bool SoSanhThoiGian(int h1, int m1, int s1, int h2, int m2, int s2)
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
            if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong" || e.Column.FieldName == "NhanVien.MaNhanVien" || e.Column.FieldName == "NhanVien.HoTen" || e.Column.FieldName == "HieuSuat" || e.Column.FieldName == "KetQua") return;
            //Tổng KQ theo kiểu int    
            decimal d = 0;
            if (gridView1.GetRowCellDisplayText(e.RowHandle, "KetQua") != string.Empty)
            {
                d = decimal.Parse(gridView1.GetRowCellDisplayText(e.RowHandle, "KetQua"));           
            }           
            if (gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.FocusedColumn) != null)
            {
                d += decimal.Parse(gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.FocusedColumn));
            }
            gridView1.SetRowCellValue(e.RowHandle, "KetQua", d);

        }
    
    }  
    
}
