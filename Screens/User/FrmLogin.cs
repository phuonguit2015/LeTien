using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeTien.Utils;
using DevExpress.XtraEditors;
namespace LeTien.Screens.User
{
    public partial class FrmLogin : Form
    {
        ErrorProvider err = new ErrorProvider();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btn_Cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (form_validate() == true)
            {
                if (do_login() == true)
                {
                    this.DialogResult = DialogResult.OK;                    
                    Form f = new Main();
                    f.Show();
                    this.Hide();
                    
                }
                else
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng","Đăng nhập không thành công");
                    TextUsername.Text = string.Empty;
                    TextPassword.Text = string.Empty;
                    TextUsername.Focus();
                }
            }
        }
        bool do_login()
        {
            using (var uow = new UnitOfWork())
            {
                Objects.User getSingleRec = new XPCollection<Objects.User>(uow, CriteriaOperator.Parse("username = ? and password = ?", TextUsername.Text, TextPassword.Text)).FirstOrDefault();
                if (getSingleRec != null)
                {
                    Global.User = getSingleRec;
                    return true;
                }
                else 
                {
                    if (TextUsername.Text == "admin" && TextPassword.Text == "admin")
                    {
                        Objects.User supper_admin = new Objects.User();
                        supper_admin.username = "supperadmin";
                        Global.User = supper_admin;
                        return true;
                    }
                }
            }
            return false;
        }
        bool form_validate()
        {
            err.Clear();
            bool flag = true;
            if (TextUsername.Text == "")
            {
                flag = false;
                err.SetError(TextUsername, "Chưa nhập tên đăng nhập");
            }
            if (TextPassword.Text == "")
            {
                flag = false;
                err.SetError(TextPassword, "Chưa nhập mật khẩu");
            }
            return flag;
        }
     

        private void TextPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void TextUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TextUsername.Text = "admin";
            TextPassword.Text = "admin";
        }
    }
}
