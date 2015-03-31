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
using DevExpress.Xpo;
using LeTien.Objects;

namespace LeTien.Screens
{
    public partial class FrmCompetence : DevExpress.XtraEditors.XtraForm
    {
        public FrmCompetence()
        {
            InitializeComponent();
        }

        private void FrmCompetence_Load(object sender, EventArgs e)
        {

        }

        private void xpCollection1_CollectionChanged(object sender, DevExpress.Xpo.XPCollectionChangedEventArgs e)
        {
            if (e.CollectionChangedType == XPCollectionChangedType.AfterRemove)
            {
                if (XtraMessageBox.Show("Bạn có chắc xóa chức vụ đang chọn không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    (sender as XPCollection).Session.Delete(e.ChangedObject);
                }
                else
                {
                    xpCollection1.Reload();
                }
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

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView currentView = sender as GridView;

            if (e.Column.FieldName == "" && currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]) != null)
            {
                var competenceID = currentView.GetRowCellValue(e.RowHandle, currentView.Columns["Oid"]).ToString();
                e.DisplayText = Objects.Competence.GetNumberOfEmployeesByCompetenceOid(competenceID, session1);
            }
        }
    }
}
