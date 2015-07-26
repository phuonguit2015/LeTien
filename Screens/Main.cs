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
using LeTien.Screens.Salaries;
using DevExpress.XtraReports.UI;
using System.IO;
using LeTien.Reports;
using LeTien.Screens.NgayNghiNgayLe;
using LeTien.TTPhongBan;
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
                //f = new frmBranchList();
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
                //f = new FrmCompetence();
                //f.Name = f.GetType().ToString();
                //e.Item.Tag = f.Name;
                //f.MdiParent = this;
                //f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void BButton_AttendanceSymbol_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Tạo giao diện ngẫu nhiên
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbGallery_Theme, true);
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

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmBangTinhLuong();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnItem_NgayNghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmQuanLyNgayNghi();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnItem_MauNgayNghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmDanhMucMauNgayNghiLe(); 
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnItem_LoaiDLChamCong_ItemClick(object sender, ItemClickEventArgs e)
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

        private void btnTamUngLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmTamUngLuong();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnGTriLuongTheoChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmTienLuongTheoChucVu();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnDanhMucCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmDanhMucCa();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnGTriDLChamCongTheoCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmGTriDLChamCongTheoCa();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnXepCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmXepCaNhanVien();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnChuKyTinhLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmCauHinhChuKyLuong();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnLoaiNgayNghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmDanhMucMauNgayNghiLe();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnLoaiDuLieuTinhLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmLoaiDuLieuTinhLuong();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }

        }

        private void btnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraReport report = new XtraReport();
            string path = Application.StartupPath + "/reportTemplate.repx";
            if(File.Exists(path))
            {
                report.LoadLayout(path);
            }
            else
            {
                report = new reportTemplate();
            }           
            ReportDesignTool tool = new ReportDesignTool(report);
            tool.ShowDesignerDialog();
        }

        private void btnImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmImportChamCong();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnBangLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmTinhLuongThang();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnCaiDat_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmThamSo();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void btnDanhMucPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            string typeName = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            Form f = GetMdiFormByName(typeName);
            if (f != null)
                f.BringToFront();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitFormMain));
                f = new FrmDanhSachPhongBan();
                f.Name = f.GetType().ToString();
                e.Item.Tag = f.Name;
                f.MdiParent = this;
                f.Show();
                SplashScreenManager.CloseForm();
            }
        }

      

    }
}