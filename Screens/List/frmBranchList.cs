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


namespace LeTien.Screens.List
{
    public partial class frmBranchList : FormBase
    {
        private Branch branch;

        public frmBranchList()
        {
            InitializeComponent();
            branch = new Branch();
        }

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            branch.BranchID = grvUCList.GetRowCellValue(e.RowHandle, "BranchID").ToString();
            branch.BranchName = grvUCList.GetRowCellValue(e.RowHandle, "BranchName").ToString();
            branch.BranchAddress = grvUCList.GetRowCellValue(e.RowHandle, "BranchAddress").ToString();
            branch.PhoneNumber = grvUCList.GetRowCellValue(e.RowHandle, "PhoneNumber").ToString();

            ucMenu.UCMain_Edit.Enabled = true;
            ucMenu.UCMain_Delete.Enabled = true;

            ucMenu.UCMain_Edit_Clicked += ucMenu_Edit_Clicked;
            ucMenu.UCMain_Delete_Clicked += ucMenu_Delete_Clicked;
        }    

        private void grvUCList_DoubleClick(object sender, EventArgs e)
        {
            FormViewBranch f = new FormViewBranch(branch);
            f.Text = "Cập nhật chi nhánh";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnNew()
        {
            FormViewBranch f = new FormViewBranch();
            f.Text = "Thêm chi nhánh";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            FormViewBranch f = new FormViewBranch(branch);
            f.Text = "Cập nhật chi nhánh";
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
                Branch br = uow.FindObject<Branch>(CriteriaOperator.Parse("BranchID = ?",branch.BranchID ));
                if(br != null)
                {
                    br.Delete();
                    uow.CommitChanges();
                    uow.PurgeDeletedObjects();
                    RefreshData();
                }
            }
        }
        protected override void OnReload()
        {
            UOW.ReloadChangedObjects();
            xpcBranch.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách chi nhánh";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách chi nhánh";
            base.OnExportXls();
        }

        private void frmBranchList_Load(object sender, EventArgs e)
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
       

       public void RefreshData()
        {
            OnReload();
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
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }            
        }

        private void ucMenu_MayTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo(string.Format(@"{0}\Tools\calc.exe", Application.StartupPath));
                proc.Start();
            }
            catch { }
        }
    }
}
