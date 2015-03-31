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

namespace LeTien.Screens.HopDong
{
    public partial class FormLaborContractList : FormBase
    {
        private LaborContract lb;
        public FormLaborContractList()
        {
            InitializeComponent();
            lb = new LaborContract();
        }

        protected override void OnNew()
        {
            FormLaborContractDetail f = new FormLaborContractDetail();
            f.Text = "Thêm hợp đồng";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            FormLaborContractDetail f = new FormLaborContractDetail(lb);
            f.Text = "Cập nhật hợp đồng";
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
                LaborContract br = uow.FindObject<LaborContract>(CriteriaOperator.Parse("MaHopDong = ?", lb.MaHopDong));
                if (br != null)
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
            xpcLaborContract.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách hợp đồng";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách hợp đồng";
            base.OnExportXls();
        }

        public void RefreshData()
        {
            OnReload();
        }

        private void FormLaborContractList_Load(object sender, EventArgs e)
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

        private void ucMenu_MayTinh_Clicked(object sender, EventArgs e)
        {
            
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

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            lb.MaHopDong = grvUCList.GetRowCellValue(e.RowHandle, "MaHopDong").ToString();
            lb.TenHopDong = grvUCList.GetRowCellValue(e.RowHandle, "TenHopDong").ToString();
            //lb.MaNhanVien = grvUCList.GetRowCellValue(e.RowHandle, "MaNhanVien").ToString();
            lb.NgayKy = DateTime.Parse(grvUCList.GetRowCellValue(e.RowHandle, "NgayKy").ToString());
            lb.NgayHetHan = DateTime.Parse(grvUCList.GetRowCellValue(e.RowHandle, "NgayHetHan").ToString());

            ucMenu.UCMain_Edit.Enabled = true;
            ucMenu.UCMain_Delete.Enabled = true;

            ucMenu.UCMain_Edit_Clicked += ucMenu_Edit_Clicked;
            ucMenu.UCMain_Delete_Clicked += ucMenu_Delete_Clicked;
        }

        private void ucMenu_Delete_Clicked(object sender, EventArgs e)
        {
            OnDelete();
        }

        private void ucMenu_Edit_Clicked(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void grvUCList_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }
    }
}
