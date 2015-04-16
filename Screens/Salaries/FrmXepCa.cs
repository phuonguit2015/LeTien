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

namespace LeTien.Screens.Salaries
{
    public partial class FrmXepCa : FormBase
    {
        public FrmXepCa()
        {
            InitializeComponent();
        }


        private string _id = string.Empty;

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                _id = grvUCList.GetRowCellValue(e.RowHandle, "Oid").ToString();
            }
        }


        #region "Override FromBase"
        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                XepCa br = uow.FindObject<XepCa>(CriteriaOperator.Parse("Oid = ?", _id));
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
            xpcXepCa.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách xếp ca";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách xếp ca";
            base.OnExportXls();
        }

        #endregion




        public void RefreshData()
        {
            OnReload();
        }

       

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnPreview();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvUCList.OptionsBehavior.ReadOnly)
            {
                btnEdit.Caption = "Đang ở chế độ chỉnh sửa";
                grvUCList.OptionsBehavior.ReadOnly = false;
                grvUCList.OptionsBehavior.Editable = true;
            }
            else
            {
                grvUCList.OptionsBehavior.Editable = false;
                grvUCList.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "Đang ở Chế độ chỉ đọc";
            }
        }

        private void btnTaoBangXepCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = new FrmTaoBangXepCa(DateTime.Parse(dtItemThang.EditValue.ToString()));
            f.Tag = this;
            f.ShowDialog();
        }
    }
}
