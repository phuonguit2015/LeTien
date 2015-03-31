using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using LeTien.Screens;
using LeTien.Screens.User;
using LeTien.Screens.Employees;
using LeTien.Utils;
using LeTien.Screens.List;
using LeTien.Screens.HopDong;
namespace LeTien.Screens
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
//        public LeTien.Object.User user = null;
        public Main()
        {
            InitializeComponent();
            
        }
        Form GetMdiFormByName(string name)
        {
            return this.MdiChildren.FirstOrDefault(f => f.Name == name);
        }

        private void BButton_UserList_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmUserList();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void barButtonIEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FormEmployeeList();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }


        private void BButon_BranchManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new frmBranch();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void BButton_PositionManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmCompetence();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void BButton_AttendanceSymbol_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmLoaiDuLieuChamCong();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //FrmLogin form_login = new FrmLogin();
            //if (form_login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    Objects.User user_login = Global.User;
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }

        private void BButton_CheckAttendance_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmAttendance();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }
       

        private void BButton_List_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }


        //Danh mục chi nhánh
        private void btnItem_ChiNhanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new frmBranchList();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        //Danh mục chức vụ
        private void btnItem_ChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new frmCompetenceList();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }


        //Danh mục tôn giáo
        private void btnItem_TonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new frmReligionList();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }


        //Danh mục ngày lễ
        private void btnItem_NgayLe_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmPublicHoliday();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void barItem_ThongTinHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FormLaborContractList();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

      

    }
}