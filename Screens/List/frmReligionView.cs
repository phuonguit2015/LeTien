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

namespace LeTien.Screens.List
{
    public partial class frmReligionView : Form
    {

        ErrorProvider er = new ErrorProvider();

        public frmReligionView()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
        }

        public frmReligionView(Religion religion)
        {
            InitializeComponent();

            txtMaTonGiao.Text = religion.ReligionID;
            txtTenTonGiao.Text = religion.ReligionName;

            btnThem.Enabled = false;
            txtMaTonGiao.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Religion update = uow.FindObject<Religion>(CriteriaOperator.Parse("ReligionID = ?", txtMaTonGiao.Text));
                if (update != null)
                {
                    update.ReligionName = txtTenTonGiao.Text;
                    try
                    {
                        if (LaHopLe() == true)
                        {
                            update.Save();
                            uow.CommitChanges();
                            frmReligionList f = this.Tag as frmReligionList;
                            f.RefreshData();
                            XtraMessageBox.Show("Cập nhật thành công", "Đã lưu");
                        }
                        //else
                        //{
                        //    if (txtTenTonGiao.Text == string.Empty)
                        //    {
                        //        XtraMessageBox.Show("Tên tôn giáo không được để trống", "Có lỗi");
                        //    }
                        //}
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
            if (txtMaTonGiao.Text == string.Empty)
            {
                er.SetError(txtMaTonGiao, "Chưa nhập mã tôn giáo!");
                return false;
            }
            if (txtTenTonGiao.Text == string.Empty)
            {
                er.SetError(txtTenTonGiao, "Chưa nhập tên tôn giáo!");
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                Religion insert = new Religion(uow);
                insert.ReligionID = txtMaTonGiao.Text;
                insert.ReligionName = txtTenTonGiao.Text;
                try
                {
                    if (LaHopLe() == true)
                    {
                        insert.Save();
                        uow.CommitChanges();
                        frmReligionList f = this.Tag as frmReligionList;
                        f.RefreshData();
                        XtraMessageBox.Show("Thêm thành công", "Đã lưu");
                        CleanForm();
                    }
                    //else
                    //{
                    //    if (txtMaTonGiao.Text == string.Empty)
                    //    {
                    //        XtraMessageBox.Show("Mã tôn giáo không được để trống", "Có lỗi");
                    //    }
                    //    else if (txtTenTonGiao.Text == string.Empty)
                    //    {
                    //        XtraMessageBox.Show("Tên tôn giáo không được để trống", "Có lỗi");
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    Religion c = uow.FindObject<Religion >(CriteriaOperator.Parse("ReligionID = ?", txtMaTonGiao.Text));
                    if (c != null)
                    {
                        er.SetError(this, "Mã tôn giáo đã tồn tại!");
                        //XtraMessageBox.Show("Mã tôn giáo đã tồn tại!!!", "Có lỗi");
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
            txtMaTonGiao.Text = string.Empty;
            txtTenTonGiao.Text = string.Empty;
        }


    }
}
