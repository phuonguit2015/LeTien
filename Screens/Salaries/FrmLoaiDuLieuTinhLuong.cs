using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LeTien.Objects;
using System.Windows.Forms;

namespace LeTien.Screens.Salaries
{
    public partial class FrmLoaiDuLieuTinhLuong : FormBase
    {
        private string _id;

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
            for (int i = 0; i < grvUCList.SelectedRowsCount; i++)
            {
                _id = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[i], colOid).ToString();

                using (var uow = new UnitOfWork())
                {
                    LoaiDuLieuTinhLuong br = uow.FindObject<LoaiDuLieuTinhLuong>(CriteriaOperator.Parse("Oid = ?", _id));
                    if (br != null)
                    {
                        br.Delete();
                        uow.CommitChanges();
                        uow.PurgeDeletedObjects();
                    }
                }
            }
            UOW.ReloadChangedObjects();
            xpcLoaiDuLieuTinhLuong.Reload();
            gridUCList.DataSource = xpcLoaiDuLieuTinhLuong;
        }

        protected override void OnReload()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            Thread.Sleep(1000);
            UOW.ReloadChangedObjects();
            xpcLoaiDuLieuTinhLuong.Reload();
            gridUCList.DataSource = xpcLoaiDuLieuTinhLuong;
            SplashScreenManager.CloseForm(); 
            
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
            OnExportXls(gridUCList);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnPreview(gridUCList, "DANH SÁCH LOẠI DỮ LIỆU TÍNH LƯƠNG", "reportTemplate.repx");

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
                grvUCList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            }
            else
            {
                grvUCList.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "CHẾ ĐỘ CHỈ ĐỌC";
                grvUCList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
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

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnReload();
        }
    }
}
