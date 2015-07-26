using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeTien.Objects;
using DevExpress.Xpo;
using LeTien.Screens;

using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using System.Diagnostics;
using System.Threading;
namespace LeTien.Screens.Employees
{
    public partial class FormEmployeeList : FormBase
    {
        private string employeeID;
        private Employee employee;

        public FormEmployeeList()
        {
            InitializeComponent();
            employee = new Employee();
            employeeID = string.Empty;

            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCompentence)).BeginInit();
            this.xpCollectionCompentence.ObjectType = typeof(LeTien.Objects.Competence);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCompentence)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.xpcReligion)).BeginInit();
            this.xpcReligion.ObjectType = typeof(LeTien.Objects.Religion);
            ((System.ComponentModel.ISupportInitialize)(this.xpcReligion)).EndInit();

        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            ucMenu.UCMain_Add_Clicked += ucMenu_Add_Clicked;
            ucMenu.UCMain_Refresh_Clicked += ucMenu_Refresh_Clicked;
            ucMenu.UCMain_Print_Clicked += ucMenu_Print_Clicked;
            ucMenu.UCMain_Export_Clicked += ucMenu_Export_Clicked;
            ucMenu.UCMain_Dong_Clicked += ucMenu_Dong_Clicked;
            ucMenu.UCMain_Edit_Clicked += ucMenu_Edit_Clicked;

            ucMenu.btnEdit.Enabled = false;
            ucMenu.btnXoa.Enabled = false;
        }
        public void RefreshData()
        {
            UOW.ReloadChangedObjects();
            xpCollectionEmployee.Reload();
            gridControl1.DataSource = xpCollectionEmployee;
        }
        private void ucMenu_MayTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo(string.Format(@"{0}\Tools\calc.exe", Application.StartupPath));
                proc.Start();
            }
            catch { }
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
            OnExportXls(gridControl1);
        }

        private void ucMenu_Print_Clicked(object sender, EventArgs e)
        {
            OnPreview(gridControl1, "DANH SÁCH NHÂN VIÊN", "reportTemplate.repx");
        }

        private void ucMenu_Refresh_Clicked(object sender, EventArgs e)
        {
            OnReload();

        }

        private void ucMenu_Add_Clicked(object sender, EventArgs e)
        {
            OnNew();
        }


        private void xpCollectionEmployee_CollectionChanged(object sender, DevExpress.Xpo.XPCollectionChangedEventArgs e)
        {
            if (e.CollectionChangedType == XPCollectionChangedType.AfterRemove)
                (sender as XPCollection).Session.Delete(e.ChangedObject);
        }

        private void bandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            //if (bandedGridView1.FocusedRowHandle < 0) return;
            //DataRow dr = bandedGridView1.GetDataRow(bandedGridView1.FocusedRowHandle);
            //if (dr == null) return;
            
            OnEdit();
        }

        private void bandedGridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (bandedGridView1.GetRowCellValue(e.RowHandle, "MaNhanVien") == null)
            {
                return;
            }
            employeeID = bandedGridView1.GetRowCellValue(e.RowHandle, "MaNhanVien").ToString();
            try
            {
                employee.MaNhanVien = bandedGridView1.GetRowCellValue(e.RowHandle, "MaNhanVien").ToString();
            }
            catch
            { }
            try
            { 
                employee.Ho = bandedGridView1.GetRowCellValue(e.RowHandle, "Ho").ToString();
            }
            catch
            { } 
            try
            {
                employee.Ten = bandedGridView1.GetRowCellValue(e.RowHandle, "Ten").ToString();
            }
            catch
            { } 
            try
            {
                employee.TenTiengNhat = bandedGridView1.GetRowCellValue(e.RowHandle, "TenTiengNhat").ToString();
            }
            catch
            { } 
            try
            {
                employee.ChucVu.CompetenceName = bandedGridView1.GetRowCellValue(e.RowHandle, "ChucVu.CompetenceName").ToString();
            }
            catch
            { } 
            try
            {
                employee.iGioiTinh = bandedGridView1.GetRowCellValue(e.RowHandle, "iGioiTinh").ToString();
            }
            catch
            { } 
            try
            {
                employee.NgaySinh = DateTime.Parse(bandedGridView1.GetRowCellValue(e.RowHandle, "NgaySinh").ToString());
            }
            catch
            { } 
            try
            {
                employee.NoiSinh = bandedGridView1.GetRowCellValue(e.RowHandle, "NoiSinh").ToString();
            }
            catch
            { } 
            try
            {
                employee.NgayVaoLam = DateTime.Parse(bandedGridView1.GetRowCellValue(e.RowHandle, "NgayVaoLam").ToString());
            }
            catch
            { } 
            try 
            {
                employee.NgayVaoBHXH = DateTime.Parse(bandedGridView1.GetRowCellValue(e.RowHandle, "NgayVaoBHXH").ToString());
            }
            catch
            { } 
            try
            {
                employee.NoiCapCMND = bandedGridView1.GetRowCellValue(e.RowHandle, "NoiCapCMND").ToString();
            }
            catch
            { } 
            try
            {
                employee.SoCMND = bandedGridView1.GetRowCellValue(e.RowHandle, "SoCMND").ToString();
            }
            catch
            { } 
            try
            {
                employee.SoDienThoai = bandedGridView1.GetRowCellValue(e.RowHandle, "SoDienThoai").ToString();
            }
            catch
            { } 
            try
            {
                employee.SoBHXH = bandedGridView1.GetRowCellValue(e.RowHandle, "SoBHXH").ToString();
            }
            catch
            { } 
            try
            {
                employee.SoTaiKhoan = bandedGridView1.GetRowCellValue(e.RowHandle, "SoTaiKhoan").ToString();
            }
            catch
            { } 
            try
            {
                employee.TonGiao.ReligionName = bandedGridView1.GetRowCellValue(e.RowHandle, "TonGiao.ReligionName").ToString();
            }
            catch
            { } 
            try
            {
                //employee.LuongCoBan = double.Parse(bandedGridView1.GetRowCellValue(e.RowHandle, "LuongCoBan").ToString());
            }
            catch
            { } 
            try
            {
                employee.DiaChiThuongTru = bandedGridView1.GetRowCellValue(e.RowHandle, "DiaChiThuongTru").ToString();
            }
            catch
            { } 
            try
            {
                employee.DiaChiTamTru = bandedGridView1.GetRowCellValue(e.RowHandle, "DiaChiTamTru").ToString();
            }
            catch
            { } 
            try
            {
                employee.ChiNhanh.BranchName = bandedGridView1.GetRowCellValue(e.RowHandle, "BranchName").ToString();
            }
            catch
            { } 
            try
            {
                employee.HopDong.MaHopDong = bandedGridView1.GetRowCellValue(e.RowHandle, "BranchName").ToString();
            }
            catch
            { }

            //ucMenu.UCMain_Edit.Enabled = true;
            //ucMenu.UCMain_Delete.Enabled = true;

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

        protected override void OnNew()
        {
            FormEmployeeDetails f = new FormEmployeeDetails();
            f.Text = "THÊM NHÂN VIÊN";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnEdit()
        {
            if (String.IsNullOrEmpty(employeeID))
                return;
            FormEmployeeDetails f = new FormEmployeeDetails(employeeID);
            f.Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN";
            f.Tag = this;
            f.ShowDialog();
        }

        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < bandedGridView1.SelectedRowsCount; i++)
            {
                employeeID = bandedGridView1.GetRowCellValue(bandedGridView1.GetSelectedRows()[i], colMaNhanVien).ToString();

                using (var uow = new UnitOfWork())
                {
                    Employee br = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", employeeID));
                    if (br != null)
                    {
                        br.Delete();
                        uow.CommitChanges();
                        RefreshData();
                    }
                }
            }
        }
        protected override void OnReload()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            Thread.Sleep(1000);
            RefreshData();
            SplashScreenManager.CloseForm();
            
        }
             


        private void grvUCList_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            ucMenu.btnEdit.Enabled = false;
            ucMenu.btnXoa.Enabled = false;
            if (bandedGridView1.SelectedRowsCount > 0)
            {
                if (bandedGridView1.SelectedRowsCount == 1)
                {
                    if (bandedGridView1.GetRowCellValue(bandedGridView1.GetSelectedRows()[0], colMaNhanVien) != null)
                    {
                        employeeID = bandedGridView1.GetRowCellValue(bandedGridView1.GetSelectedRows()[0], colMaNhanVien).ToString();
                        ucMenu.btnEdit.Enabled = true;
                    }
                }
                ucMenu.btnXoa.Enabled = true;
            }
            else
            {
                ucMenu.btnEdit.Enabled = false;
                ucMenu.btnXoa.Enabled = false;
            }
        }

        private void checkXem_CheckedChanged(object sender, EventArgs e)
        {
            if(checkXem.Checked == true)
            {
                checkXem.Text = "CHẾ ĐỘ XEM";
                bandedGridView1.OptionsBehavior.ReadOnly = true;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            else
            {
                checkXem.Text = "CHẾ ĐỘ CHỈNH SỬA";
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                bandedGridView1.NewItemRowText = "Thêm dòng mới tại đây...";
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            }
        }

        private void bandedGridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }


    }
}
