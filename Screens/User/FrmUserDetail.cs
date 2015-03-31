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
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace LeTien.Screens.User
{
    public partial class FrmUserDetail : LeTien.Screens.FormBase
    {
        private Objects.User user;
        ErrorProvider err = new ErrorProvider();
        string form_type = "";

        public FrmUserDetail()
        {
            InitializeComponent();
            user = new Objects.User();
            binding_data();
            form_type = "new";
        }
        public FrmUserDetail(Objects.User input_user)
        {
            InitializeComponent();
            user = input_user;
            binding_data();
            form_type = "edit";
        }
        void binding_data() {
            TextUsername.DataBindings.Clear();
            TextUserpass.DataBindings.Clear();

            TextUsername.DataBindings.Add("EditValue", user, "username");
            TextUserpass.DataBindings.Add("EditValue", user, "password");
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (validate_form() == true)
            {
                try
                {
                    Saves();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi không mong muốn sãy ra, không thể lưu dữ liệu\n\n" + ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //binding_data();
                    this.Close();
                }
            }
        }
        private void Save2()
        {
            user.Save();
            if (!IsChanged)
            {
                return;
            }
            try
            {
                UOW.CommitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        bool validate_form()
        {
            err.Clear();
            bool flag = true;
            if (TextUsername.Text == "")
            {
                flag = false;
                err.SetError(TextUsername, "Chưa nhập tên đăng nhập");
            }
            if (TextUserpass.Text == "")
            {
                flag = false;
                err.SetError(TextUserpass, "Chưa nhập mật khẩu");
            }
            if (TextUserpass2.Text == "")
            {
                flag = false;
                err.SetError(TextUserpass2, "Chưa nhập mật khẩu");
            }
            if (TextUserpass.Text != "" && TextUserpass2.Text != "")
            {
                if (TextUserpass.Text != TextUserpass2.Text)
                {
                    flag = false;
                    err.SetError(TextUserpass2, "Nhập lại mật khẩu chưa đúng");
                }
            }
            if (flag == true && form_type == "new")
            {
                using (var uow = new UnitOfWork())
                {
                    Objects.User getSingleRec = new XPCollection<Objects.User>(uow, CriteriaOperator.Parse("username = ?", TextUsername.Text)).FirstOrDefault();
                    if (getSingleRec != null)
                    {
                        flag = false;
                        err.SetError(TextUsername, "Tên đăng nhập đã tồn tại");
                    }
                }
            }
            return flag;
        }

        private void FrmUserDetail_Load(object sender, EventArgs e)
        {
            if (form_type == "edit")
            {
                TextUsername.Enabled = false;
            }
        }
    }
}