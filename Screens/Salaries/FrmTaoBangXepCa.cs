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
    public partial class FrmTaoBangXepCa : Form
    {
        Point p = Point.Empty;
        public FrmTaoBangXepCa()
        {
            InitializeComponent();
        }

        public FrmTaoBangXepCa(DateTime thang)
        {
            InitializeComponent();
            dtThang.EditValue = thang;
        }


        private void lBoxNhanVienSource_MouseDown(object sender, MouseEventArgs e)
        {
            ListBoxControl l = sender as ListBoxControl;
            p = new Point(e.X, e.Y);
            int s = l.IndexFromPoint(p);
            if(s == -1)
            {
                p = Point.Empty;
            }
        }

        private void lBoxNhanVienSource_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(p != Point.Empty && (Math.Abs(e.X - p.X) > SystemInformation.DragSize.Width || 
                    Math.Abs(e.Y - p.Y) > SystemInformation.DragSize.Height))
                {
                    lBoxNhanVienSource.DoDragDrop(sender, DragDropEffects.Move);
                }
            }
        }

        private void lBoxNhanVienDes_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lBoxNhanVienDes_DragDrop(object sender, DragEventArgs e)
        {
            ListBoxControl l = sender as ListBoxControl;
            Point newPoint = new Point(e.X, e.Y);
            newPoint = l.PointToClient(newPoint);
            int s = l.IndexFromPoint(newPoint);
            //DataRowView drView = lBoxNhanVienSource.SelectedItem as DataRowView;
            //(l.DataSource as DataTable).Rows.Add(new object);
            int a = lBoxNhanVienSource.IndexFromPoint(p);
            //object item = lBoxNhanVienSource.Items[lBoxNhanVienSource.IndexFromPoint(p)];
            object item = lBoxNhanVienSource.SelectedItem;

            if(s == -1)
            {
                l.Items.Add(item);
            }
            else
            {
                l.Items.Insert(s, item);
            }
            lBoxNhanVienSource.Items.Remove(item);
        }

        private void FrmTaoBangXepCa_Load(object sender, EventArgs e)
        {           

            foreach(Employee nv in xpcNhanVien)
            {
                DateTime ngay = new DateTime(dtThang.DateTime.Year, dtThang.DateTime.Month, 1);
                DateTime ngay2 = new DateTime(dtThang.DateTime.Year, dtThang.DateTime.Month, SoNgayTrongThang(dtThang.DateTime.Month, dtThang.DateTime.Year));
                XPCollection xpcNV = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("NhanVien",nv), new BinaryOperator("Ngay",ngay,BinaryOperatorType.GreaterOrEqual),
                    new BinaryOperator("Ngay",ngay2,BinaryOperatorType.LessOrEqual)));
                if(xpcNV.Count == 0)
                {
                    lBoxNhanVienSource.Items.Add(nv);
                }               
            }
            
        }

        private void lBoxNhanVienSource_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            e.Cache.DrawString((lBoxNhanVienSource.GetItem(e.Index) as Employee).HoTen, e.Appearance.Font,
                new SolidBrush(Color.Black), e.Bounds, e.Appearance.GetStringFormat());
            e.Handled = true;
        }

        private void lBoxNhanVienDes_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            e.Cache.DrawString((lBoxNhanVienDes.GetItem(e.Index) as Employee).HoTen, e.Appearance.Font,
              new SolidBrush(Color.Black), e.Bounds, e.Appearance.GetStringFormat());
            e.Handled = true;
        }

        private int SoNgayTrongThang(int m, int y)
        {
            int daysInMonth;

            DateTime now = DateTime.Now;

            if (m == 0 || y == 0)
            {

                daysInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
                m = now.Month;
                y = now.Year;
            }
            else
            {
                daysInMonth = System.DateTime.DaysInMonth(y, m);
            }
            return daysInMonth;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //for(int i = 1; i <= SoNgayTrongThang(dtThang.DateTime.Month, dtThang.DateTime.Year); i++)
            //{
            //    foreach(object nv in lBoxNhanVienDes.Items)
            //    {
            //        XepCa xepca = new XepCa()
            //        {
            //            NhanVien = nv as Employee,
            //            //Ngay = new DateTime(dtThang.DateTime.Year, dtThang.DateTime.Month, i),
            //            Ca = lkupCa.EditValue as DanhMucCa
            //        };
            //        XPCollection xpc = new XPCollection(xpcXepCa, CriteriaOperator.Parse("NhanVien = '" + xepca.NhanVien + "' AND Ngay = '" + xepca.Ngay + "'"));                   
            //        if(xpc.Count == 0)
            //        {
            //            xpcXepCa.Add(xepca);
            //        }
            //    }
            //}
            //XpoDefault.Session.Save(xpcXepCa);
            //XtraMessageBox.Show("Lưu thông tin thành công");
            //FrmXepCa f = this.Tag as FrmXepCa;
            //f.RefreshData();
        }

        private void lkupCa_EditValueChanged(object sender, EventArgs e)
        {
            lBoxNhanVienDes.Items.Clear();
            foreach (Employee nv in xpcNhanVien)
            {
                DateTime ngay = new DateTime(dtThang.DateTime.Year, dtThang.DateTime.Month, 1);
                DateTime ngay2 = new DateTime(dtThang.DateTime.Year, dtThang.DateTime.Month, SoNgayTrongThang(dtThang.DateTime.Month, dtThang.DateTime.Year));
                XPCollection xpcNV = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("NhanVien", nv), new BinaryOperator("Ngay", ngay, BinaryOperatorType.GreaterOrEqual),
                    new BinaryOperator("Ngay", ngay2, BinaryOperatorType.LessOrEqual), new BinaryOperator("Ca",lkupCa.EditValue as DanhMucCa)));
                if (xpcNV.Count > 0)
                {                    
                    lBoxNhanVienDes.Items.Add(nv);
                }
            }
        }
    }
}
