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
    public partial class FrmLoaiDuLieuChamCongDetail : Form
    {
        ErrorProvider er = new ErrorProvider();
        public FrmLoaiDuLieuChamCongDetail()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
            this.BindingContext[xpcLoaiDuLieuChamCong].AddNew();
        }

        public FrmLoaiDuLieuChamCongDetail(string id)
        {
            InitializeComponent();
            using (var uow = new UnitOfWork())
            {
                LoaiDuLieuChamCong l = uow.FindObject<LoaiDuLieuChamCong>(CriteriaOperator.Parse("LoaiChamCong =  ?", id));
                if (l != null)
                {
                    this.xpcLoaiDuLieuChamCong.CriteriaString = "[LoaiChamCong] = \'" + l.LoaiChamCong + "\'";

                    btnThem.Enabled = false;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (LaHopLe() == true)
            {
                Session s = XpoDefault.Session;
                s.Save(xpcLoaiDuLieuChamCong);
                FrmLoaiDuLieuChamCong f = this.Tag as FrmLoaiDuLieuChamCong;
                f.RefreshData();
                XtraMessageBox.Show("Cập nhật thành công", "Đã lưu");
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra!", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LaHopLe() == true)
            {
                Session s = XpoDefault.Session;
                s.Save(xpcLoaiDuLieuChamCong);
                FrmLoaiDuLieuChamCong f = this.Tag as FrmLoaiDuLieuChamCong;
                f.RefreshData();
                XtraMessageBox.Show("Thêm mới thành công", "Đã lưu");
                this.BindingContext[xpcLoaiDuLieuChamCong].AddNew();
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra!", "Thông báo");
            }
        }

        private bool LaHopLe()
        {
            er.Clear();
            bool flag = true;
            if (txtLoaiDuLieu.Text == string.Empty)
            {
                er.SetError(txtLoaiDuLieu, "Vui lòng nhập kiểu dữ liệu.");
                flag = false;
            }
            if (cbbKieuDuLieu.Text == string.Empty)
            {
                er.SetError(cbbKieuDuLieu, "Vui lòng chọn kiểu dữ liệu.");
                flag = false;
            }
            return flag;
        }

        private void cbbKieuDuLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
