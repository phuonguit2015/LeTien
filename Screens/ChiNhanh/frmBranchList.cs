using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeTien.Objects;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.XtraSplashScreen;
using System.Threading;
using LeTien.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;


namespace LeTien.Screens.List
{
    public partial class frmBranchList : FormBase
    {
        private string branchID;
        public frmBranchList()
        {
            InitializeComponent();
           
        }


        protected override void OnNew()
        {
            FormViewBranch f = new FormViewBranch();
            f.Text = "THÊM CHI NHÁNH";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            FormViewBranch f = new FormViewBranch(branchID);
            f.Text = "CẬP NHẬT CHI NHÁNH";
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
                branchID = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[i], colBranchID).ToString();
                using (var uow = new UnitOfWork())
                {
                    Branch br = uow.FindObject<Branch>(CriteriaOperator.Parse("BranchID = ?", branchID));
                    if (br != null)
                    {
                        br.Delete();
                        uow.CommitChanges();
                        uow.PurgeDeletedObjects();
                    }
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
            xpcBranch.Reload();
            gridUCList.DataSource = xpcBranch;
        }

        private void ucMenu_Export_Clicked(object sender, EventArgs e)
        {
            OnExportXls(gridUCList);
        }

        private void ucMenu_Print_Clicked(object sender, EventArgs e)
        {
            OnPreview(gridUCList, "DANH SÁCH CHI NHÁNH", "reportTemplate.repx");
        
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
                    branchID = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[0], colBranchID).ToString();
                }
                ucMenu.btnXoa.Enabled = true;
            }
            else
            {
                ucMenu.btnEdit.Enabled = false;
                ucMenu.btnXoa.Enabled = false;
            }
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
