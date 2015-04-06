using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmLoaiDuLieuChamCong : FormBase
    {
        private string _id = string.Empty;
        public FrmLoaiDuLieuChamCong()
        {
            InitializeComponent();
        }

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _id = grvUCList.GetRowCellValue(e.RowHandle, "LoaiChamCong").ToString();

            ucMenu.UCMain_Edit.Enabled = true;
            ucMenu.UCMain_Delete.Enabled = true;

            ucMenu.UCMain_Edit_Clicked += ucMenu_Edit_Clicked;
            ucMenu.UCMain_Delete_Clicked += ucMenu_Delete_Clicked;
        }
    
        private void grvUCList_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        #region "Override FromBase"
        protected override void OnNew()
        {
            FrmLoaiDuLieuChamCongDetail f = new FrmLoaiDuLieuChamCongDetail();
            f.Text = "Thêm loại dữ liệu hợp đồng";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            FrmLoaiDuLieuChamCongDetail f = new FrmLoaiDuLieuChamCongDetail(_id);
            f.Text = "Cập nhật loại dữ liệu chấm công";
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
                LoaiDuLieuChamCong br = uow.FindObject<LoaiDuLieuChamCong>(CriteriaOperator.Parse("LoaiChamCong = ?", _id));
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
            xpcLoaiDuLieuChamCong.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách loại dữ liệu chấm công";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách loại dữ liệu chấm công";
            base.OnExportXls();
        }

        #endregion

        #region "Event UCMenu"
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
            throw new NotImplementedException();
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

        #endregion

        private void frmBranchList_Load(object sender, EventArgs e)
        {
            ucMenu.UCMain_Add_Clicked += ucMenu_Add_Clicked;
            ucMenu.UCMain_Refresh_Clicked += ucMenu_Refresh_Clicked;
            ucMenu.UCMain_Print_Clicked += ucMenu_Print_Clicked;
            ucMenu.UCMain_Export_Clicked += ucMenu_Export_Clicked;
            ucMenu.UCMain_Dong_Clicked += ucMenu_Dong_Clicked;
            ucMenu.UCMain_MayTinh_Clicked += ucMenu_MayTinh_Clicked;

            ucMenu.UCMain_Edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucMenu.UCMain_Delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucMenu.UCMain_Add.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucMenu.UCMain_MayTinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            ucMenu.UCMain_MayTinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        public void RefreshData()
        {
            OnReload();
        }

        private void grvUCList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.Column.FieldName == "DuLieuMacDinh")
            {
                if (gv.GetRowCellValue(e.RowHandle, gv.Columns["KieuDuLieu"]) != null)
                {
                    var l = gv.GetRowCellValue(e.RowHandle, grvUCList.Columns["KieuDuLieu"]);                   
                    switch (l.ToString())
                    {
                        case "Int":
                            e.RepositoryItem = spinEdit;
                            break;
                        case "DateTime":
                            e.RepositoryItem = repositoryItemTimeEdit1;
                            break;
                        case "String":
                            e.RepositoryItem = textEdit;
                            break;
                    }


                }
            }


        }
    }
}
