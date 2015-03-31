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
        public event EventHandler UCMain_MayTinh_Clicked;


        private void UCMain_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UCMain_Delete_Clicked != null)
                UCMain_Delete_Clicked(this, e);
        }
         private void UCMain_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             if (UCMain_Add_Clicked != null)
                 UCMain_Add_Clicked(this, e);
         }
        private void UCMain_Refresh_ItemClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UCMain_Refresh_Clicked != null)
                UCMain_Refresh_Clicked(this, e);
        }

        private void UCMain_Print_ItemClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UCMain_Print_Clicked != null)
                UCMain_Print_Clicked(this, e);
        }
        private void UCMain_Export_ItemClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UCMain_Export_Clicked != null)
                UCMain_Export_Clicked(this, e);
        }
        private void UCMain_Edit_ItemClicked(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UCMain_Edit_Clicked != null)
                UCMain_Edit_Clicked(this, e);
        }

        private void UCMain_Dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UCMain_Dong_Clicked != null)
                UCMain_Dong_Clicked(this, e);
        }

        private void UCMain_MayTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UCMain_MayTinh_Clicked != null)
                UCMain_MayTinh_Clicked(this, e);
        }
    }
}
