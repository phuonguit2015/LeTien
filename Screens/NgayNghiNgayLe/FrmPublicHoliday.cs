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
using System.Threading;


namespace LeTien.Screens
{
    public partial class FrmPublicHoliday : FormBase
    {
        private int Oid;
        public FrmPublicHoliday()
        {
            InitializeComponent();
            spinNam.EditValue = DateTime.Now.Year;
        }

        #region "Override FormBase"
        protected override void OnNew()
        {
            FrmPublicHolidayDetail f = new FrmPublicHolidayDetail();
            f.Text = "THÊM NGÀY NGHĨ LỄ";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            FrmPublicHolidayDetail f = new FrmPublicHolidayDetail(Oid);
            f.Text = "CẬP NHẬT NGÀY NGHĨ LỄ";
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
                Oid = int.Parse(grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[i], colOid).ToString());

                using (var uow = new UnitOfWork())
                {
                    PublicHoliday br = uow.FindObject<PublicHoliday>(CriteriaOperator.Parse("Oid = ?", Oid));
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

       

        
#endregion
        public void RefreshData()
        {
            UOW.ReloadChangedObjects();
            xpcPublicHoliday.Reload();
            gridUCList.DataSource = xpcPublicHoliday;
        }

        private void FrmPublicHoliday_Load(object sender, EventArgs e)
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
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            OnPreview(gridUCList, "DANH SÁCH NGÀY NGHĨ LỄ", "reportTemplate.repx");

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

        private void grvUCList_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
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
                    Oid = int.Parse(grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[0], colOid).ToString());
                }
                ucMenu.btnXoa.Enabled = true;
            }
            else
            {
                ucMenu.btnEdit.Enabled = false;
                ucMenu.btnXoa.Enabled = false;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            xpcPublicHoliday.Reload();

            int year = int.Parse(spinNam.EditValue.ToString());
            XPCollection xpc = new XPCollection(xpcPublicHoliday, CriteriaOperator.And(new BinaryOperator("PublicHolidayStart", new DateTime(year, 1, 1), BinaryOperatorType.GreaterOrEqual),
            new BinaryOperator("PublicHolidayEnd", new DateTime(year, 12, 31), BinaryOperatorType.LessOrEqual)));

            gridUCList.DataSource = xpc;
        }
    }
}
