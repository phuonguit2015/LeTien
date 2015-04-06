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
    public partial class FrmDanhMucMauNgayNghiLe : FormBase
    {
        private string _tenNgayNghi = string.Empty;
        public FrmDanhMucMauNgayNghiLe()
        {
            InitializeComponent();
            btnXoa.Enabled = false;
        }
        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                DanhMucMauNgayNghiLe br = uow.FindObject<DanhMucMauNgayNghiLe>(CriteriaOperator.Parse("TenNgayNghi = ?", _tenNgayNghi));
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
            xpcDanhMucMauNgayNghiLe.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách danh mục màu ngày nghĩ lễ";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách danh mục màu ngày nghĩ lễ";
            base.OnExportXls();
        }


        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnPreview();
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvUCList.OptionsBehavior.ReadOnly)
            {
                btnEdit.Caption = "Chế độ chỉnh sửa";
                grvUCList.OptionsBehavior.ReadOnly = false;
                //btnEdit.Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/edit_16x16.png");
            }
            else
            {
                grvUCList.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "Chế độ chỉ đọc";
                //btnEdit.Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_16x16.png");

            }
        }

        private void grvUCList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            _tenNgayNghi = grvUCList.GetRowCellDisplayText(e.RowHandle,"TenNgayNghi");
            btnXoa.Enabled = true;
        }

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _tenNgayNghi = grvUCList.GetRowCellDisplayText(e.RowHandle, "TenNgayNghi");
            btnXoa.Enabled = true;
        }
    }
}
