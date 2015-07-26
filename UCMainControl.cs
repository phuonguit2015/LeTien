using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LeTien
{
    public partial class UCMainControl : UserControl
    {
        public UCMainControl()
        {
            InitializeComponent();
        }
        public event EventHandler UCMain_Add_Clicked;
        public event EventHandler UCMain_Refresh_Clicked;
        public event EventHandler UCMain_Edit_Clicked;
        public event EventHandler UCMain_Print_Clicked;
        public event EventHandler UCMain_Export_Clicked;
        public event EventHandler UCMain_Delete_Clicked;
        public event EventHandler UCMain_Dong_Clicked;
        public event EventHandler UCMain_ThemTuExcel_Clicked;


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (UCMain_Add_Clicked != null)
                UCMain_Add_Clicked(this, e);
        }

        private void btnThemTuExcel_Click(object sender, EventArgs e)
        {
            if (UCMain_ThemTuExcel_Clicked != null)
                UCMain_ThemTuExcel_Clicked(this, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UCMain_Edit_Clicked != null)
                UCMain_Edit_Clicked(this, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (UCMain_Delete_Clicked != null)
                UCMain_Delete_Clicked(this, e);
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
             if (UCMain_Refresh_Clicked != null)
                UCMain_Refresh_Clicked(this, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (UCMain_Print_Clicked != null)
                UCMain_Print_Clicked(this, e);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (UCMain_Export_Clicked != null)
                UCMain_Export_Clicked(this, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (UCMain_Dong_Clicked != null)
                UCMain_Dong_Clicked(this, e);
        }
    }
}
