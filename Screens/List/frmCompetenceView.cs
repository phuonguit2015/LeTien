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
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace LeTien.Screens.List
{
    public partial class frmCompetenceView : Form
    {
        ErrorProvider er = new ErrorProvider();
        public frmCompetenceView()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
        }

        public frmCompetenceView(Competence competence)
        {
            btnThem.Enabled = false;
            txtMaChucVu.Enabled = false;

            txtMaChucVu.Text = competence.CompetenceID;
            txtTenChucVu.Text = competence.CompetenceName;
            txtTienPhuCap.Text = competence.Allowance;
        }

        private void txtTienPhuCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                XtraMessageBox.Show("Tiền phụ cấp phải là số", "Có lỗi!");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Competence update = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", txtMaChucVu.Text));
                if (update != null)
                {
                    update.CompetenceName = txtTenChucVu.Text;
                    update.Allowance = txtTienPhuCap.Text;
                    try
                    {
                        if (LaHopLe() == true)
                        {
                            update.Save();
                            uow.CommitChanges();
                            frmCompetenceList f = this.Tag as frmCompetenceList;
                            f.RefreshData();
                            XtraMessageBox.Show("Cập nhật thành công", "Đã lưu");
                        }                       
                    }

                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Có lỗi!");
                    }
                }
            }
        }
        private bool LaHopLe()
        {
            er.Clear();
            if (txtMaChucVu.Text == string.Empty)
            {
                er.SetError(txtMaChucVu, "Chưa nhập mã chức vụ!");
                return false;
            }
            if( txtTenChucVu.Text == string.Empty)
            {
                er.SetError(txtTenChucVu, "Chưa nhập tên chức vụ!");
                return false;
            }
            if(txtTienPhuCap.Text == string.Empty)
            {
                er.SetError(txtTienPhuCap, "Chưa nhập tiền phụ cấp!");
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Competence insert = new Competence(uow);
                insert.CompetenceID = txtMaChucVu.Text;
                insert.CompetenceName = txtTenChucVu.Text;
                insert.Allowance = txtTienPhuCap.Text;
                try
                {
                    if (LaHopLe() == true)
                    {
                        insert.Save();
                        uow.CommitChanges();
                        frmBranchList f = this.Tag as frmBranchList;
                        f.RefreshData();
                        XtraMessageBox.Show("Thêm thành công", "Đã lưu");
                        CleanForm();
                    //}
                    //else
                    //{
                    //    if (txtMaChucVu.Text == string.Empty)
                    //    {
                    //        XtraMessageBox.Show("Mã chức vụ không được để trống", "Có lỗi");
                    //    }
                    //    else if (txtTenChucVu.Text == string.Empty)
                    //    {
                    //        XtraMessageBox.Show("Tên chức vụ không được để trống", "Có lỗi");
                    //    }
                    //    else if (txtTienPhuCap.Text == string.Empty)
                    //    {
                    //        XtraMessageBox.Show("Tiền phụ cấp không được để trống", "Có lỗi");
                    //    }
                    }
                }
                catch (Exception ex)
                {
                    Competence c = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", txtMaChucVu.Text));
                    if (c != null)
                    {
                        er.SetError(this,"Mã chức vụ đã tồn tại!");
                        //XtraMessageBox.Show("Mã chức vụ đã tồn tại!!!", "Có lỗi");
                    }
                    else
                    {
                        XtraMessageBox.Show(ex.Message, "Có lỗi!");
                    }
                }
            }
        }

        private void CleanForm()
        {
            txtMaChucVu.Text = string.Empty;
            txtTenChucVu.Text = string.Empty;
            txtTienPhuCap.Text = string.Empty;
        }

    }
}
