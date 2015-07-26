using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using LeTien.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LeTien.Screens.List
{
    public partial class frmCompetenceList : FormBase
    {
        private string competenceID;
        public frmCompetenceList()
        {
            InitializeComponent();
        }

        protected override void OnNew()
        {
            frmCompetenceView f = new frmCompetenceView();
            f.Text = "THÊM CHỨC VỤ";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            frmCompetenceView f = new frmCompetenceView(competenceID);
            f.Text = "CẬP NHẬT CHỨC VỤ";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < grvUCList.SelectedRowsCount; i++)
            {
                competenceID = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[i], colBranchID).ToString();

                Competence br = XpoDefault.Session.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", competenceID));
                if (br != null)
                {
                    br.Delete();
                    XpoDefault.Session.CommitTransaction();
                    XpoDefault.Session.PurgeDeletedObjects();
                }
            }
            RefreshData();
        }
        protected override void OnReload()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            Thread.Sleep(1000);
            RefreshData();            
            SplashScreenManager.CloseForm();  
        }
                

        private void frmBranchList_Load(object sender, EventArgs e)
        {
            ucMenu.UCMain_Add_Clicked += ucMenu_Add_Clicked;
            ucMenu.UCMain_Refresh_Clicked += ucMenu_Refresh_Clicked;
            ucMenu.UCMain_Print_Clicked += ucMenu_Print_Clicked;
            ucMenu.UCMain_Export_Clicked += ucMenu_Export_Clicked;
            ucMenu.UCMain_Dong_Clicked += ucMenu_Dong_Clicked;
            ucMenu.UCMain_Delete_Clicked += ucMenu_Delete_Clicked;
            ucMenu.UCMain_Edit_Clicked += ucMenu_Edit_Clicked;


            ucMenu.btnEdit.Enabled = false;
            ucMenu.btnXoa.Enabled = false;


        }


        public void RefreshData()
        {
            UOW.ReloadChangedObjects();
            xpcCompetence.Reload();
            gridUCList.DataSource = xpcCompetence;
        }

        private void ucMenu_Export_Clicked(object sender, EventArgs e)
        {
            OnExportXls(gridUCList);
        }

        private void ucMenu_Print_Clicked(object sender, EventArgs e)
        {
            OnPreview(gridUCList, "DANH SÁCH CHỨC VỤ", "reportTemplate.repx");
        }

        private void ucMenu_Refresh_Clicked(object sender, EventArgs e)
        {
            OnReload();
        }

        private void ucMenu_Add_Clicked(object sender, EventArgs e)
        {
            OnNew();
        }
        private void ucMenu_Edit_Clicked(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void ucMenu_Delete_Clicked(object sender, EventArgs e)
        {
            OnDelete();

        }
        private void ucMenu_Dong_Clicked(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void grvUCList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            ucMenu.btnEdit.Enabled = false;
            ucMenu.btnXoa.Enabled = false;
            if (grvUCList.SelectedRowsCount > 0)
            {
                if (grvUCList.SelectedRowsCount == 1)
                {
                    ucMenu.btnEdit.Enabled = true;
                    competenceID = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[0], colBranchID).ToString();
                }
                ucMenu.btnXoa.Enabled = true;
            }
            else
            {
                ucMenu.btnEdit.Enabled = false;
                ucMenu.btnXoa.Enabled = false;
            }
        }
    }

}
