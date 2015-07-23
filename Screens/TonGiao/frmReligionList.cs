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
    public partial class frmReligionList : FormBase
    {
        private string religionID;
        public frmReligionList()
        {
            InitializeComponent();
        }

        protected override void OnNew()
        {
            frmReligionView f = new frmReligionView();
            f.Text = "THÊM TÔN GIÁO";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            frmReligionView f = new frmReligionView(religionID);
            f.Text = "CẬP NHẬT TÔN GIÁO";
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
                religionID = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[i], colBranchID).ToString();
                using (var uow = new UnitOfWork())
                {
                    Religion br = uow.FindObject<Religion>(CriteriaOperator.Parse("ReligionID = ?", religionID));
                    if (br != null)
                    {
                        br.Delete();
                        uow.CommitChanges();
                        uow.PurgeDeletedObjects();
                    }
                }
            }

            OnReload();
        }

        protected override void OnReload()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            UOW.ReloadChangedObjects();
            xpcReligion.Reload();
            Thread.Sleep(1000);
            gridUCList.DataSource = xpcReligion;
            SplashScreenManager.CloseForm();            
        }

       

        public void RefreshData()
        {
            OnReload();
        }

        private void frmReligionList_Load(object sender, EventArgs e)
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

        private void ucMenu_Dong_Clicked(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ucMenu_Export_Clicked(object sender, EventArgs e)
        {
            OnExportXls(gridUCList);
        }

        private void ucMenu_Print_Clicked(object sender, EventArgs e)
        {
            OnPreview(gridUCList, "DANH SÁCH TÔN GIÁO", "reportTemplate.repx");

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

        private void grvUCList_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            ucMenu.btnEdit.Enabled = false;
            ucMenu.btnXoa.Enabled = false;
            if (grvUCList.SelectedRowsCount > 0)
            {
                if (grvUCList.SelectedRowsCount == 1)
                {
                    ucMenu.btnEdit.Enabled = true;
                    religionID = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[0], colBranchID).ToString();
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
