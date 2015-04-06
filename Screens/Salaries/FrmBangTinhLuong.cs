using DevExpress.Xpo;
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

namespace LeTien.Screens.Salaries
{
    public partial class FrmBangTinhLuong : Form
    {
        public FrmBangTinhLuong()
        {
            InitializeComponent();
        }

        private void btnLoaiDuLieuTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoaiDuLieuTinhLuong f = new LoaiDuLieuTinhLuong();
            f.ShowDialog();
        }

        private void TinhLuong()
        {
            
        }
    }
}
