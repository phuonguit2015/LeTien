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

namespace LeTien.Screens.Employees
{
    public partial class FormEmployeeDetails : Form
    {
        public FormEmployeeDetails()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
            //this.xpcEmployee.Add(new NhanVien);
            this.BindingContext[xpcEmployee].AddNew();
        }

        public FormEmployeeDetails(string ID)
        {
            InitializeComponent();
            using (var uow = new UnitOfWork())
            {
                Employee employee = uow.FindObject<Employee>(CriteriaOperator.Parse("MaNhanVien =  ?", ID));
                if (employee != null)
                {
                    this.xpcEmployee.CriteriaString = "[MaNhanVien] = \'" + employee.MaNhanVien + "\'";
                   
                    btnThem.Enabled = false;
                }
            }
        }
        public FormEmployeeDetails(Employee employee)
        {
            InitializeComponent();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Session s = XpoDefault.Session;
            s.Save(xpcEmployee);
            FormEmployeeList f = this.Tag as FormEmployeeList;
            f.RefreshData();            
            XtraMessageBox.Show("Thêm mới thành công", "Đã lưu");
            
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Session s = XpoDefault.Session;
            s.Save(xpcEmployee);
            FormEmployeeList f = this.Tag as FormEmployeeList;
            f.RefreshData();
            XtraMessageBox.Show("Cập nhật thành công", "Đã lưu");
        }
       
        
        private bool LaHopLe()
        {
            return true;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void calDiemA_TextChanged(object sender, EventArgs e)
        {
            //txtLuongCoBan.Text = (double.Parse(calDiemA.Text) * 20000).ToString();
        }

        //private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    using (var uow = new UnitOfWork())
        //    {
        //        txtPhuCapChucVu.Text = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", lkuChucVu.Text)).Allowance; 
        //    }
        //}

        private void txtHo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkuChucVu_EditValueChanged(object sender, EventArgs e)
        {
             using (var uow = new UnitOfWork())
             {
                 if (lkuChucVu.EditValue != null)
                 {
                     Competence c = uow.FindObject<Competence>(CriteriaOperator.Parse("CompetenceID = ?", (lkuChucVu.EditValue as Competence).CompetenceID));
                     if (c != null)
                     {
                         txtPhuCapChucVu.Text = c.Allowance;
                     }
                 }
             }
        }

        private void lkuSoHopDong_EditValueChanged(object sender, EventArgs e)
        {

        }

  
   
    }
}
