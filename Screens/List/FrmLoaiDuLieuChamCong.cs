using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LeTien.Screens.List
{
    public partial class FrmLoaiDuLieuChamCong : FormBase
    {
        private string _id = string.Empty;
        public FrmLoaiDuLieuChamCong()
        {
            InitializeComponent();
        }
     

        #region "Override FromBase"
        protected override void OnNew()
        {
            
        }

        protected override void OnEdit()
        {
            
        }

        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < grvUCList.SelectedRowsCount; i++)
            {
                _id = grvUCList.GetRowCellValue(grvUCList.GetSelectedRows()[i], colOid).ToString();

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
        }
        protected override void OnReload()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            UOW.ReloadChangedObjects();
            xpcLoaiDuLieuChamCong.Reload();
            Thread.Sleep(1000);
            gridUCList.DataSource = xpcLoaiDuLieuChamCong;
            SplashScreenManager.CloseForm(); 
        }

        

        #endregion

      

        private void frmBranchList_Load(object sender, EventArgs e)
        {
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnPreview(gridUCList, "DANH SÁCH LOẠI DỮ LIỆU CHẤM CÔNG", "reportTemplate.repx");

        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls(gridUCList);           
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }     
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
                grvUCList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;

            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
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

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnReload();
        }
    }
}
