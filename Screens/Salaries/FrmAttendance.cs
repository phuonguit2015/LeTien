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
            this.renderAttendanDateceColumn();
            //this.renderAttendanceSymbol();

        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DateOfMonth")
            {
                GridView currentView = sender as GridView;
                string employeeID = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]).ToString();
                //int date = int.Parse(e.Column.Caption.ToString());
                int date = e.Column.VisibleIndex - 1;

                string attendanceDate = this.attendanceYear.ToString() + "-" + (this.attendanceMonth < 10 ? "0" + this.attendanceMonth.ToString() : this.attendanceMonth.ToString()) + "-" + (date < 10 ? "0" + date.ToString() : date.ToString());

                //int attendanceColor = Objects.Attendance.GetAttendanceSymbolColorEmployeeByDate(employeeID, attendanceDate, session1);
                //if (attendanceColor != 0)
                //{
                //    e.Appearance.BackColor = System.Drawing.Color.FromArgb(attendanceColor); 
                //    //e.DisplayText = Objects.Attendance.GetAttendanceSymbolKeyEmployeeByDate(employeeID, attendanceDate, session1);
                //}
            }
        }


        public void renderAttendanDateceColumn()
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


            foreach (GridColumn col in ((ColumnView)gridControl1.Views[0]).Columns)
            {
                if (col.FieldName.Contains("Ngay"))
                {
                    string s = col.FieldName.Substring(4);
                    if (int.Parse(s) > daysInMonth)
                    {
                        col.Visible = false;
                        continue;
                    }
                    for (int i = 1; i <= daysInMonth; i++)
                    {
                        if (i == int.Parse(s))
                        {
                            DateTime curDate = new DateTime(this.attendanceYear, this.attendanceMonth, i);
                            col.Caption = i.ToString() + " (" + dateVN(curDate.DayOfWeek.ToString()) + ")";
                            col.VisibleIndex = i + 4;
                            col.Visible = true;
                            if (curDate.DayOfWeek.ToString() == "Sunday")
                            {
                                col.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
                                col.AppearanceHeader.Options.UseForeColor = true;
                            }
                            break;
                        }
                    }
                }
            }
        }


        public void renderAttendanceSymbol()
        {
            layoutControl1.BeginUpdate();

            //DevExpress.Xpo.DB.SelectedData resAttendanceSymbols = Objects.AttendanceSymbol.GetAllAttendanceSymbols(session1);

            //if (resAttendanceSymbols.ResultSet[0].Rows.Length > 0)
            //{
            //    for (int i = 0; i < resAttendanceSymbols.ResultSet[0].Rows.Length; i++)
            //    {
            //        int symbolColor = int.Parse(resAttendanceSymbols.ResultSet[0].Rows[i].Values[3].ToString());

            //        LayoutControlItem newItem = new LayoutControlItem();

            //        newItem.Control = new LabelControl();

            //        newItem.Control.BackColor = System.Drawing.Color.FromArgb(symbolColor);
            //        newItem.Control.Text = resAttendanceSymbols.ResultSet[0].Rows[i].Values[1].ToString();
            //        Size newSize = new Size(105, 41);
            //        newItem.MaxSize = newSize;
            //        newItem.MinSize = newSize;
            //        layoutControlGroup2.AddItem(newItem);
            //    }
            //}




            layoutControl1.EndUpdate();
        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column.Name == "DateOfMonth")
            {
                GridView currentView = sender as GridView;
                string employeeID = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]).ToString();
                string employeeFName = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["first_name"]).ToString();
                string employeeLName = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["last_name"]).ToString();
                string employeeIDText = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["employee_id"]).ToString();
                //int date = int.Parse(e.Column.Caption.ToString());
                int date = e.Column.VisibleIndex - 1;

                string attendanceDate = this.attendanceYear.ToString() + "-" + (this.attendanceMonth < 10 ? "0" + this.attendanceMonth.ToString() : this.attendanceMonth.ToString()) + "-" + (date < 10 ? "0" + date.ToString() : date.ToString());
                /// string attendanceID = Objects.Attendance.GetAttendanceIdOfEmployeeByDate(employeeID, attendanceDate, session1);

                //Call form input attendance
                string frmCaption = "Chấm công nhân viên - " + employeeLName + " " + employeeLName + " (" + employeeIDText + ") ngày " + attendanceDate;
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                FrmPutAttendance frm = new FrmPutAttendance();
                System.Threading.Thread.Sleep(2000);
                frm.Text = frmCaption;
                frm.Show();
                SplashScreenManager.CloseForm();

            }
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
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            this.attendanceMonth = DateTime.Parse(dtThang.EditValue.ToString()).Month;
            this.attendanceYear = DateTime.Parse(dtThang.EditValue.ToString()).Year;

            System.Threading.Thread.Sleep(2000);
            this.renderAttendanDateceColumn();
            gridControl1.DataSource = TaoBangChamCong();

            SplashScreenManager.CloseForm();
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
            if (e.Column.FieldName == "LoaiDuLieuChamCong.LoaiChamCong") return;
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
            if (e.Column.VisibleIndex > 2 && e.Column.VisibleIndex < 31)
            {
                LoaiDuLieuChamCong l = (LoaiDuLieuChamCong)gv.GetRowCellValue(e.RowHandle, gv.Columns["LoaiDuLieuChamCong!"]);
                if (gv.GetRowCellValue(e.RowHandle, e.Column)==null) return;
                string value = gv.GetRowCellValue(e.RowHandle, e.Column).ToString();


                e.Appearance.BackColor = LayMauHienThi(l, value);
               // e.Appearance.BackColor2 = Color.AliceBlue;
            }
        }

        private Color LayMauHienThi(LoaiDuLieuChamCong l, string value)
        {
            if( l.KieuDuLieu == "Int" && Int32.Parse(value) > Int32.Parse(l.DuLieuMacDinh)) 
                return l.MauHienThiDuong;
            else
                return l.MauHienThiAm;
            
        }


    }
}
