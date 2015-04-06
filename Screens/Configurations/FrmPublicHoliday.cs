using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using LeTien.Objects;
using LeTien.Screens;
using DevExpress.Utils;
using LeTien.Screens.Configurations;
using DevExpress.Data.Filtering;

namespace LeTien.Screens
{
    public partial class FrmPublicHoliday : FormBase
    {
        private string  _TenNgayNghi = string.Empty;
        public FrmPublicHoliday()
        {
            InitializeComponent();
            spinNam.EditValue = DateTime.Now.Year;
        }

        #region "Override FormBase"
        protected override void OnNew()
        {
            FrmPublicHolidayDetail f = new FrmPublicHolidayDetail();
            f.Text = "Thêm ngày nghĩ, ngày lễ";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            FrmPublicHolidayDetail f = new FrmPublicHolidayDetail(_TenNgayNghi);
            f.Text = "Cập nhật ngày nghĩ, ngày lễ";
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
                PublicHoliday br = uow.FindObject<PublicHoliday>(CriteriaOperator.Parse("PublicHolidayName = ?", _TenNgayNghi));
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
            xpcPublicHoliday.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách ngày nghĩ, ngày lễ";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách ngày nghĩ, ngày lễ   ";
            base.OnExportXls();
        }
#endregion
        public void RefreshData()
        {
            OnReload();
        }

        private void FrmPublicHoliday_Load(object sender, EventArgs e)
        {
            ucMenu.UCMain_Add_Clicked += ucMenu_Add_Clicked;
            ucMenu.UCMain_Refresh_Clicked += ucMenu_Refresh_Clicked;
            ucMenu.UCMain_Print_Clicked += ucMenu_Print_Clicked;
            ucMenu.UCMain_Export_Clicked += ucMenu_Export_Clicked;
            ucMenu.UCMain_Dong_Clicked += ucMenu_Dong_Clicked;
            ucMenu.UCMain_MayTinh_Clicked += ucMenu_MayTinh_Clicked;

            ucMenu.UCMain_Edit.Enabled = false;
            ucMenu.UCMain_MayTinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            _TenNgayNghi = grvUCList.GetRowCellValue(e.RowHandle, "PublicHolidayName").ToString();

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

        private void spinNam_EditValueChanged(object sender, EventArgs e)
        {
            int year = int.Parse(spinNam.EditValue.ToString());
            //DateTime date = new DateTime(int.Parse(spinNam.EditValue.ToString()), 1, 1);
            //CriteriaOperator criteria = CriteriaOperator.And(
            //   new BinaryOperator("PublicHolidayStart", date, BinaryOperatorType.Greater),
            //   new BinaryOperator("PublicHolidayEnd", date, BinaryOperatorType.Greater));
            CriteriaOperator criteria = CriteriaOperator.Parse("PublicHolidayStart like '%" + year + "%' AND PublicHolidayEnd like '%" + year + "%'");
            xpcPublicHoliday.Filter = criteria;
        }
    }
}
