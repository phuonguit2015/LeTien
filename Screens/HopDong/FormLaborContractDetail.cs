using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LeTien.Objects;
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

        public FormLaborContractDetail(LaborContract lb)
        {
            InitializeComponent();
            //txtMaHopDong.Enabled = false;
            //txtMaHopDong.Text = lb.MaHopDong;
            //txtTenHopDong.Text = lb.TenHopDong;
            ////cbbMaNV.SelectedValue = lb.MaNhanVien;
            //dtNgayKy.Text = lb.NgayKy.ToShortDateString();
            //dtNgayHetHan.EditValue = lb.NgayHetHan.ToShortDateString();
            //cbbChucVu.SelectedValue = LayChucVuCuaNhanVien(lb.MaNhanVien);
            //calLuongCoBan.Text = (LayLuongCoBanCuaNhanVien(lb.MaNhanVien) / 20000).ToString();
        }

        private string LayChucVuCuaNhanVien(string MaNhanVien)
        {
            using (var uow = new UnitOfWork())
            {
                Employee lb = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", MaNhanVien));
                if (lb != null)
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
           //xtLuongCoBan.Text = (double.Parse(calLuongCoBan.Text) * 20000).ToString();
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (var uow = new UnitOfWork())
            //{
            //    Employee nv = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien = ?", cbbMaNV.Text));
            //    if(nv != null)
            //    {
            //        CleanTTNV();
            //        txtHoTen.Text = nv.HoTen;
            //        //txtChiNhanh.Text = nv.ChiNhanh.BranchName;
            //        txtChucVu.Text = nv.ChucVu.CompetenceName;
            //        dtNgaySinh.Text = nv.NgaySinh.ToShortDateString();
            //        txtSoCMND.Text = nv.SoCMND;
            //        dtNgayCap.Text = nv.NgayCapCMND.ToShortDateString();
            //        txtNoiCap.Text = nv.NoiCapCMND;
            //    }
            //}
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Competence nv = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", cbbChucVu.SelectedValue));
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
            //bool flag = true;
            //using (var uow = new UnitOfWork())
            //{
            //    LaborContract lb = uow.FindObject<LaborContract>(CriteriaOperator.Parse("MaHopDong = ?", txtMaHopDong.Text));
            //    if(lb == null)
            //    {
            //        lb = new LaborContract(uow);
            //        flag = false;
            //        lb.MaHopDong = txtMaHopDong.Text;
            //    }                
            //    lb.TenHopDong = txtTenHopDong.Text;
            //    lb.MaNhanVien = cbbMaNV.Text;
            //    lb.NgayKy = DateTime.Parse(dtNgayKy.Text);
            //    lb.NgayHetHan = DateTime.Parse(dtNgayHetHan.Text);
            //    try
            //    {
            //        if (LaHopLe() == true)
            //        {
            //            lb.Save();
            //            uow.CommitChanges();
            //            FormLaborContractList f = this.Tag as FormLaborContractList;
            //            f.RefreshData();
            //            if (flag == false)
            //            {

            //                XtraMessageBox.Show("Thêm thành công", "Đã lưu");
            //            }
            //            else
            //            {
            //                XtraMessageBox.Show("Cập nhật thành công", "Đã lưu");
            //            }
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show(ex.Message, "Có lỗi!");
            //    }
            //}
        }

        private bool LaHopLe()
        {
            er.Clear();
            bool flag = true;
            //if(txtTenHopDong.Text == string.Empty)
            //{
            //    er.SetError(txtTenHopDong, "Chưa nhập tên hợp đồng!");
            //    flag = false;
            //}
            //if (txtHoTen.Text == string.Empty)
            //{
            //    er.SetError(cbbMaNV, "Chưa nhập thông tin nhân viên!");
            //    flag = false;
            //}
            //if(dtNgayKy.DateTime == null)
            //{
            //    er.SetError(dtNgayKy, "Chưa nhập thông tin ngày ký!");
            //    flag = false;
            //}
            //if (dtNgayHetHan.DateTime == null)
            //{
            //    er.SetError(dtNgayHetHan, "Chưa nhập thông tin ngày hết hạn!");
            //    flag = false;
            //}
            //if (txtPhuCapChucVu.Text == string.Empty)
            //{
            //    er.SetError(cbbChucVu, "Chưa nhập thông tin chức vụ!");
            //    flag = false;
            //}
            //if (calLuongCoBan.Text == string.Empty)
            //{
            //    er.SetError(calLuongCoBan, "Chưa nhập thông tin lương cơ bản!");
            //    flag = false;
            //}
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
    }
}
