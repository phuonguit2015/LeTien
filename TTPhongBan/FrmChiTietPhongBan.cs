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

namespace LeTien.TTPhongBan
{
    public partial class FrmChiTietPhongBan : Form
    {
         ErrorProvider er = new ErrorProvider();

        public FrmChiTietPhongBan()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;

        }
        public FrmChiTietPhongBan(string Oid)
        {
            InitializeComponent();
            using (var uow = new UnitOfWork())
            {
                PhongBan pb = uow.FindObject<PhongBan>(CriteriaOperator.Parse("Oid = ?", Oid));
                if (pb != null)
                {
                    txtMaPhongBan.Text = pb.MaPhongBan;
                    txtTenPhongBan.Text = pb.TenPhongBan;
                    txtGhiChu.Text = pb.GhiChu;
                }
            }
            btnThem.Enabled = false;
            txtMaPhongBan.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                PhongBan update = uow.FindObject<PhongBan>(CriteriaOperator.Parse("Oid = ?", txtMaPhongBan.Text));
                if (update != null)
                {
                    update.TenPhongBan = txtTenPhongBan.Text;
                    update.GhiChu = txtGhiChu.Text;
                    try
                    {
                        if (LaHopLe() == true)
                        {
                            update.Save();
                            uow.CommitChanges();
                            FrmDanhSachPhongBan f = this.Tag as FrmDanhSachPhongBan;
                            f.RefreshData();
                            XtraMessageBox.Show("Cập nhật thành công!", "THÔNG BÁO");
                            txtMaPhongBan.Focus();
                        }
                    }

                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "THÔNG BÁO");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                PhongBan insert = new PhongBan(uow);
                insert.MaPhongBan = txtMaPhongBan.Text;
                insert.TenPhongBan = txtTenPhongBan.Text;
                insert.GhiChu = txtGhiChu.Text;
                try
                {
                    if (LaHopLe() == true)
                    {
                        insert.Save();
                        uow.CommitChanges();
                        FrmDanhSachPhongBan f = this.Tag as FrmDanhSachPhongBan;
                        f.RefreshData();
                        XtraMessageBox.Show("Thêm thành công", "Đã lưu");
                        CleanForm();
                        txtMaPhongBan.Focus();
                    }
                }
                catch (Exception ex)
                {
                    PhongBan b = uow.FindObject<PhongBan>(CriteriaOperator.Parse("MaPhongBan = ?", txtMaPhongBan.Text));
                    if (b != null)
                    {
                        er.SetError(txtMaPhongBan, "Mã Phòng Ban đã tồn tại!");
                        XtraMessageBox.Show("Mã phòng ban đã tồn tại!!!", "THÔNG BÁO");
                    }
                    else
                    {
                        XtraMessageBox.Show(ex.Message, "THÔNG BÁO");
                    }
                }
            }
        }

        private bool LaHopLe()
        {
            er.Clear();
            if (txtMaPhongBan.Text == string.Empty)
            {
                er.SetError(txtMaPhongBan, "Chưa nhập mã phòng ban!");
                return false;
            }
            if (txtTenPhongBan.Text == string.Empty)
            {
                er.SetError(txtTenPhongBan, "Chưa nhập tên phòng ban!");
                return false;
            }
            return true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                XtraMessageBox.Show("Số điện thoại phải là số", "THÔNG BÁO");
            }
        }

        private void CleanForm()
        {
            txtMaPhongBan.Text = string.Empty;
            txtTenPhongBan.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }


        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Nếu là thêm mới
                if (btnThem.Enabled == true)
                {
                    btnThem_Click(sender, e);
                }
                else
                {
                    btnLuu_Click(sender, e);
                }
            }
        }

    }
}
