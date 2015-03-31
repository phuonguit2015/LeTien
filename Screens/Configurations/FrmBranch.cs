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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.Xpo;
using LeTien.Objects;

namespace LeTien.Screens
{
    public partial class frmBranch : DevExpress.XtraEditors.XtraForm
    {
        public frmBranch()
        {
            InitializeComponent();
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {
            if (xpCollection1.Count == 0)
            {
                var branch = new Branch(session1);
                branch.BranchID = "BID001";
                branch.BranchName = "Chi nhánh Hồ Chí Minh";
                branch.Save();
                xpCollection1.Add(branch);
                branch = new Branch(session1);
                branch.BranchID = "BID002";
                branch.BranchName = "Chi nhánh Đà Nẵng";
                branch.Save();
                xpCollection1.Add(branch);
            }
            
            // Create an unbound column.
            /*var totalEmployeeColum = new GridColumn();
            totalEmployeeColum.Caption = "Number NhanVien";

            totalEmployeeColum.VisibleIndex = gridView1.Columns.Count;
            totalEmployeeColum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // Disable editing.
            totalEmployeeColum.OptionsColumn.AllowEdit = false;
            // Specify format settings.
            totalEmployeeColum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            totalEmployeeColum.DisplayFormat.FormatString = "c";
            // Customize the appearance settings.
            totalEmployeeColum.AppearanceCell.BackColor = Color.LemonChiffon;

            gridView1.Columns.Insert(gridView1.Columns.Count, totalEmployeeColum);*/

        }


        private void gridControl1_EmbeddedNavigator_ControlAdded(object sender, ControlEventArgs e)
        {
            XtraMessageBox.Show("add");
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            /*GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string i = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Oid"]);
                if (Convert.ToInt32(i) % 2 == 0) 
                {
                    e.Appearance.BackColor = Color.Tan;
                    e.Appearance.BackColor2 = Color.Teal;
                }
                else
                {
                }
            }*/
        }

        private void xpCollection1_CollectionChanged(object sender, DevExpress.Xpo.XPCollectionChangedEventArgs e)
        {
            if (e.CollectionChangedType == XPCollectionChangedType.AfterRemove)
            {
                if (XtraMessageBox.Show("Bạn có chắc xóa chi nhánh đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    (sender as XPCollection).Session.Delete(e.ChangedObject);
                }
                else
                {
                    xpCollection1.Reload();
                }
            }
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            GridView currentView = sender as GridView;

            if (e.Column.FieldName == "" && currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]) != null)
            {
                var branchID = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]).ToString();
                e.DisplayText = Objects.Branch.GetNumberOfEmployeesByBranchOid(branchID, session1);
            }

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView currentView = sender as GridView;
                currentView.DeleteRow(currentView.FocusedRowHandle);
            }
            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                GridView currentView = sender as GridView;
                currentView.AddNewRow();
            }
        }

    }
}
