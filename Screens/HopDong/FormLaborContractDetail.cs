using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LeTien.Objects;
using LeTien.Screens.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.HopDong
{
    public partial class FormLaborContractDetail : Form
    {
        ErrorProvider er = new ErrorProvider();
        public FormLaborContractDetail()
        {
            InitializeComponent();
        }

        public FormLaborContractDetail(string _maHopDong)
        {
            InitializeComponent();
            using (var uow = new UnitOfWork())
            {
                LaborContract lb = uow.FindObject<LaborContract>(CriteriaOperator.Parse("MaHopDong = ?", _maHopDong));
                if (lb != null)
                {                    
                    txtMaHopDong.Enabled = false;
                    txtMaHopDong.Text = lb.MaHopDong;
                    cbbLoaiHopDong.Text = lb.LoaiHopDong;
                    lkMaNhanVien.EditValue = lb.iNhanVien.MaNhanVien;
                    dtNgayKy.Text = lb.NgayKy.ToShortDateString();
                    dtNgayHetHan.EditValue = lb.NgayHetHan.ToShortDateString();
                    lkChucVu.EditValue = LayChucVuCuaNhanVien(lb.iNhanVien.MaNhanVien);
                    calLuongCoBan.Text = (LayLuongCoBanCuaNhanVien(lb.iNhanVien.MaNhanVien)).ToString();
                }
            }
        }

        public FormLaborContractDetail(LaborContract lb)
        {
            InitializeComponent();
      
        }

        private string LayChucVuCuaNhanVien(string MaNhanVien)
        {
            using (var uow = new UnitOfWork())
            {
                Employee lb = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", MaNhanVien));
                if (lb != null && lb.ChucVu != null)
                    return lb.ChucVu.CompetenceID;
                return null;
            }
        }

        private decimal LayLuongCoBanCuaNhanVien(string MaNhanVien)
        {
            using (var uow = new UnitOfWork())
            {
                Employee lb = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", MaNhanVien));
                if (lb != null)
                    return lb.LuongCoBan;
                return 0;
            }
        }

        private void calDiemA_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Employee nv = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", lkMaNhanVien.EditValue));
                if (nv != null)
                {
                    CleanTTNV();
                    txtHoTen.Text = nv.HoTen;
                    txtChiNhanh.Text = nv.ChiNhanh == null ? "" : nv.ChiNhanh.BranchName;
                    txtChucVu.Text = nv.ChucVu == null ? "" : nv.ChucVu.CompetenceName;
                    dtNgaySinh.Text = String.IsNullOrEmpty(nv.NgaySinh.ToShortDateString()) ? "" : nv.NgaySinh.ToShortDateString();
                    txtSoCMND.Text = String.IsNullOrEmpty(nv.SoCMND) ? "" : nv.SoCMND;
                    dtNgayCap.Text = String.IsNullOrEmpty(nv.NgayCapCMND.ToShortDateString()) ? "" : nv.NgayCapCMND.ToShortDateString();
                    txtNoiCap.Text = String.IsNullOrEmpty(nv.NoiCapCMND) ? "" : nv.NoiCapCMND;
                }
            }
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Competence nv = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", lkChucVu.EditValue));
                if (nv != null)
                {
                    txtPhuCapChucVu.Text = nv.Allowance;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool flag = true;

            #region "Lưu Thông Tin Hợp Đồng"            

            using (var uow = new UnitOfWork())
            {
                LaborContract lb = uow.FindObject<LaborContract>(CriteriaOperator.Parse("MaHopDong = ?", txtMaHopDong.Text));
                if (txtMaHopDong.Enabled == true && lb != null)
                {
                    XtraMessageBox.Show("Mã hợp đồng đã tồn tại. Vui lòng nhập mã khác.", "THÔNG BÁO");
                    return;
                }
                if (lb == null)
                {                    
                    lb = new LaborContract(uow);
                    flag = false;
                    lb.MaHopDong = txtMaHopDong.Text;
                }
                lb.LoaiHopDong = cbbLoaiHopDong.Text;
                lb.iNhanVien = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?",lkMaNhanVien.EditValue));
                lb.NgayKy = DateTime.Parse(dtNgayKy.Text);
                lb.NgayHetHan = DateTime.Parse(dtNgayHetHan.Text);
                lb.ChucVu = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", lkChucVu.EditValue));
                lb.LuongCoBan = decimal.Parse(calLuongCoBan.Text);
                try
                {
                    if (LaHopLe() == true)
                    {
                        lb.Save();
                        uow.CommitChanges();
                        FormLaborContractList f = this.Tag as FormLaborContractList;
                        f.RefreshData();
                        if (flag == false)
                        {
                            XtraMessageBox.Show("Thêm thành công", "Đã lưu");
                        }
                        else
                        {
                            XtraMessageBox.Show("Cập nhật thành công", "Đã lưu");
                        }
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Có lỗi!");
                }
            }
            #endregion

            #region "Cập Nhật Thông Tin Nhân Viên"
            using (var uow = new UnitOfWork())
            {
                Employee update = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", lkMaNhanVien.EditValue));
                if (update != null)
                {
                    update.ChucVu = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", lkChucVu.EditValue));
                    update.HopDong =  uow.FindObject<LaborContract>(CriteriaOperator.Parse("MaHopDong = ?",txtMaHopDong.Text));
                    update.LuongCoBan = decimal.Parse(calLuongCoBan.Text);
                    update.TinhTrangHopDong = cbbLoaiHopDong.Text;
                    try
                    {
                        if (LaHopLe() == true)
                        {
                            update.Save();
                            uow.CommitChanges();                            
                        }
                    }

                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Có lỗi!");
                    }
                }
            }
            #endregion
        }

        private bool LaHopLe()
        {
            er.Clear();
            bool flag = true;
            if (txtMaHopDong.Text == string.Empty)
            {
                er.SetError(txtMaHopDong, "Nhập số hợp đồng!");
                flag = false;
            }
            //if(cbbLoaiHopDong.Text == string.Empty)
            //{
            //    er.SetError(cbbLoaiHopDong, "Chọn loại hợp đồng!");
            //    flag = false;
            //}
            if (txtHoTen.Text == string.Empty)
            {
                er.SetError(lkMaNhanVien, "Chọn Nhân Viên!");
                flag = false;
            }
            if(dtNgayKy.DateTime == null)
            {
                er.SetError(dtNgayKy, "Chọn ngày ký!");
                flag = false;
            }
            if (dtNgayHetHan.DateTime == null)
            {
                er.SetError(dtNgayHetHan, "Chọn ngày hết hạn!");
                flag = false;
            }
            //if (txtPhuCapChucVu.Text == string.Empty)
            //{
            //    er.SetError(lkChucVu, "Chọn chức vụ!");
            //    flag = false;
            //}
            if (calLuongCoBan.Text == string.Empty)
            {
                er.SetError(calLuongCoBan, "Nhập lương cơ bản!");
                flag = false;
            }
            if(dtNgayKy.DateTime.CompareTo(dtNgayHetHan.DateTime) > 0)
            {
                er.SetError(dtNgayHetHan, "Ngày hết hạn phải lớn hơn ngày kí!");
                flag = false;
            }
            return flag;
        }

        private void FormLaborContractDetail_Load(object sender, EventArgs e)
        {
           
        }

        private void CleanTTNV()
        {            
            txtHoTen.Text = string.Empty;
            txtChiNhanh.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            dtNgaySinh.Text = string.Empty;
            txtSoCMND.Text = string.Empty;
            dtNgayCap.Text = string.Empty;
            txtNoiCap.Text = string.Empty;
        }

        private void dtNgayKy_EditValueChanged(object sender, EventArgs e)
        {
            dtNgayHetHan.EditValue = dtNgayKy.EditValue;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FormEmployeeDetails f = new FormEmployeeDetails();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                xpcEmployee.Reload();
            }
            
        }
    }
}
