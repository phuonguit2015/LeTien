using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Columns;
namespace LeTien.Screens.User
{
    public partial class FrmUserList : Form
    {
        public FrmUserList()
        {
            
            InitializeComponent();
        }

        void ucMainControl1_UCMain_Add_Clicked(object sender, EventArgs e)
        {
            FrmUserDetail frm = new FrmUserDetail();
            frm.Show();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            UserList_Control.UCMain_Add_Clicked += ucMainControl1_UCMain_Add_Clicked;
            UserList_Control.UCMain_Refresh_Clicked += UserList_Control_UCMain_Refresh_Clicked;
            UserList_Control.UCMain_Edit_Clicked += UserList_Control_UCMain_Edit_Clicked;

            UserList_Control.UCMain_Export.Enabled = false;
            UserList_Control.UCMain_Print.Enabled = false;
            UserList_Control.UCMain_Delete.Enabled = false;
        }

        void UserList_Control_UCMain_Edit_Clicked(object sender, EventArgs e)
        {
            if (bandedGridView1.FocusedRowHandle < 0) return;
            try
            {
                Objects.User user = (Objects.User)bandedGridView1.GetRow(bandedGridView1.FocusedRowHandle);
                if (user == null)
                {
                    MessageBox.Show("Chưa chọn nhân viên", "Thông báo lỗi");
                    return;
                }
                using (var uow = new UnitOfWork())
                {
                    //Object.NhanVien getRecords = new XPCollection<Object.NhanVien>(uow, CriteriaOperator.Parse("Oid = ?", employee_id)).FirstOrDefault();
                    Objects.User getRecords = uow.GetObjectByKey<Objects.User>(user.Oid);
                    if (getRecords == null) return;
                    FrmUserDetail f = new FrmUserDetail(getRecords);
                    f.ShowDialog();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi không mong muốn sảy ra/n" + ex.ToString(), "Thông báo lỗi");
            }
        }

        void UserList_Control_UCMain_Refresh_Clicked(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            xpCollectionUser.Reload();
            //gridControl1.Refresh();
            SplashScreenManager.CloseForm();
        }

        private void xpCollectionUser_CollectionChanged(object sender, XPCollectionChangedEventArgs e)
        {
            if (e.CollectionChangedType == XPCollectionChangedType.AfterRemove)
                (sender as XPCollection).Session.Delete(e.ChangedObject);
        }

        private void bandedGridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "edit_user")
            {
                GridColumn col = view.Columns["view_user"];
                int row = view.FocusedRowHandle;
                bool val = (bool)view.GetRowCellValue(row, col);
                if(val == false)
                {
                    e.Cancel = true;
                }
            }
            if (view.FocusedColumn.FieldName == "edit_employee")
            {
                GridColumn col = view.Columns["view_employee"];
                int row = view.FocusedRowHandle;
                bool val = (bool)view.GetRowCellValue(row, col);
                if (val == false)
                {
                    e.Cancel = true;
                }
            }
                
        }
        private void RI_CheckViewUser_CheckedChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit checkedit = (DevExpress.XtraEditors.CheckEdit)sender;
            if (checkedit.Checked == false)
            {
                GridColumn col = bandedGridView1.Columns["edit_user"];
                int row = bandedGridView1.FocusedRowHandle;
                bool val = (bool)bandedGridView1.GetRowCellValue(row, col);
                if (val == true)
                {
                    bandedGridView1.SetRowCellValue(row, col, false);
                }
            }
        }

        private void RI_CheckViewEmployee_CheckedChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit checkedit = (DevExpress.XtraEditors.CheckEdit)sender;
            if (checkedit.Checked == false)
            {
                GridColumn col = bandedGridView1.Columns["edit_employee"];
                int row = bandedGridView1.FocusedRowHandle;
                bool val = (bool)bandedGridView1.GetRowCellValue(row, col);
                if (val == true)
                {
                    bandedGridView1.SetRowCellValue(row, col, false);
                }
            }
        }

        
    }
}
