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

namespace LeTien.Screens.List
{
    public partial class frmCompetenceList : FormBase
    {
        private Competence competence;
        public frmCompetenceList()
        {
            InitializeComponent();
            competence = new Competence();
        }

        private void grvUCList_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            competence.CompetenceID = grvUCList.GetRowCellValue(e.RowHandle, "CompetenceID").ToString();
            competence.CompetenceName = grvUCList.GetRowCellValue(e.RowHandle, "CompetenceName").ToString();
            competence.Allowance = grvUCList.GetRowCellValue(e.RowHandle, "Allowance").ToString();

            ucMenu.UCMain_Edit.Enabled = true;
            ucMenu.UCMain_Delete.Enabled = true;

            ucMenu.UCMain_Edit_Clicked += ucMenu_Edit_Clicked;
            ucMenu.UCMain_Delete_Clicked += ucMenu_Delete_Clicked;
        }

        protected override void OnNew()
        {
            frmCompetenceView f = new frmCompetenceView();
            f.Text = "Thêm chức vụ";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            frmCompetenceView f = new frmCompetenceView(competence);
            f.Text = "Cập nhật chức vụ";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                Branch br = uow.FindObject<Branch>(CriteriaOperator.Parse("CompetenceID = ?", competence.CompetenceID));
                if (br != null)
                {
                    br.Delete();
                    uow.CommitChanges();
                    uow.PurgeDeletedObjects();
                    OnReload();
                }
            }
        }

        protected override void OnReload()
        {
            UOW.ReloadChangedObjects();
            xpcCompetence.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách chức vụ";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách chức vụ";
            base.OnExportXls();
        }

        public void RefreshData()
        {
            OnReload();
        }
        private void frmCompetenceList_Load(object sender, EventArgs e)
        {
            ucMenu.UCMain_Add_Clicked += ucMenu_Add_Clicked;
            ucMenu.UCMain_Refresh_Clicked += ucMenu_Refresh_Clicked;
            ucMenu.UCMain_Print_Clicked += ucMenu_Print_Clicked;
            ucMenu.UCMain_Export_Clicked += ucMenu_Export_Clicked;
            ucMenu.UCMain_Dong_Clicked += ucMenu_Dong_Clicked;
            ucMenu.UCMain_MayTinh_Clicked += ucMenu_MayTinh_Clicked;

            ucMenu.UCMain_Edit.Enabled = false;
            ucMenu.UCMain_Delete.Enabled = false;
        }

        private void ucMenu_Dong_Clicked(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ucMenu_Export_Clicked(object sender, EventArgs e)
        {
            OnExportXls();
        }

        private void ucMenu_Print_Clicked(object sender, EventArgs e)
        {
            OnPreview();
        }

        private void ucMenu_Refresh_Clicked(object sender, EventArgs e)
        {
            OnReload();
        }

        private void ucMenu_Add_Clicked(object sender, EventArgs e)
        {
            OnNew();
        }

        private void ucMenu_Delete_Clicked(object sender, EventArgs e)
        {
            OnDelete();
        }

        private void ucMenu_Edit_Clicked(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void ucMenu_MayTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Process proc = new Process();
                //proc.StartInfo = new ProcessStartInfo(string.Format(@"{0}\Tools\calc.exe", Application.StartupPath));
                //proc.Start();
            }
            catch { }
        }
    }
}
