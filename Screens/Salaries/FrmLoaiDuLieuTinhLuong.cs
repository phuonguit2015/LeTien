using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.Salaries
{
    public partial class FrmLoaiDuLieuTinhLuong : FormBase
    {
        private string _tenLoaiDuLieu;

        public FrmLoaiDuLieuTinhLuong()
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
                FrmLoaiDuLieuTinhLuong br = uow.FindObject<FrmLoaiDuLieuTinhLuong>(CriteriaOperator.Parse("TenLoaiDuLieu = ?", _tenLoaiDuLieu));
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
            xpcLoaiDuLieuTinhLuong.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách mục tính lương";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách mục tính lương";
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
                btnEdit.Caption = "Đang ở chế độ chỉnh sửa";
                grvUCList.OptionsBehavior.ReadOnly = false;
            }
            else
            {
                grvUCList.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "Đang ở chế độ chỉ đọc";
            }
        }

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _tenLoaiDuLieu = grvUCList.GetRowCellDisplayText(e.RowHandle, "TenLoaiDuLieu");
            btnXoa.Enabled = true;
        }
    }
}
