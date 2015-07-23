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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.NgayNghiNgayLe
{
    public partial class FrmQuanLyNgayNghi : FormBase
    {
        private int Oid;
        public FrmQuanLyNgayNghi()
        {
            InitializeComponent();
            btnXoa.Enabled = false;
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
                    QuanLyNgayNghi br = uow.FindObject<QuanLyNgayNghi>(CriteriaOperator.Parse("Oid = ?", Oid));
                    if (br != null)
                    {
                        br.Delete();
                        uow.CommitChanges();
                        uow.PurgeDeletedObjects();
                        OnReload();
                    }
                }
            }
        }


        protected override void OnReload()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            Thread.Sleep(1000);
            UOW.ReloadChangedObjects();
            xpcQuanLyNgayNghi.Reload();
            SplashScreenManager.CloseForm();

        }



        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls(gridUCList);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            OnPreview(gridUCList, "DANH SÁCH NGÀY NGHĨ", "reportTemplate.repx");
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvUCList.OptionsBehavior.ReadOnly)
            {
                btnEdit.Caption = "CHẾ ĐỘ CHỈNH SỬA";
                grvUCList.OptionsBehavior.ReadOnly = false;
                grvUCList.OptionsBehavior.Editable = true;
                grvUCList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            }
            else
            {
                grvUCList.OptionsBehavior.Editable = false;
                grvUCList.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "CHẾ ĐỘ CHỈ ĐỌC";
                grvUCList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }



        private void FrmQuanLyNgayNghi_Load(object sender, EventArgs e)
        {
        }


        private void grvUCList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            btnXoa.Enabled = false;
            if (grvUCList.SelectedRowsCount > 0)
            {
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
    }
}
