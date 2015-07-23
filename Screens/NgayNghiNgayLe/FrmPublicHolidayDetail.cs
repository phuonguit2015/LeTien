﻿using DevExpress.Data.Filtering;
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

namespace LeTien.Screens.Configurations
{
    public partial class FrmPublicHolidayDetail : Form
    {
        ErrorProvider er = new ErrorProvider();
        public FrmPublicHolidayDetail()
        {
            InitializeComponent();
            btnCapNhat.Enabled = false;
            this.BindingContext[xpcPublicHoliday].AddNew();
        }

        public FrmPublicHolidayDetail(int Oid)
        {

            InitializeComponent();
            using (var uow = new UnitOfWork())
            {
                PublicHoliday ngaynghi = uow.FindObject<PublicHoliday>(CriteriaOperator.Parse("Oid =  ?", Oid));
                if (ngaynghi != null)
                {
                    this.xpcPublicHoliday.CriteriaString = "[Oid] = \'" + Oid + "\'";

                    btnThem.Enabled = false;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LaHopLe() == true)
            {
                Session s = XpoDefault.Session;
                s.Save(xpcPublicHoliday);
                XtraMessageBox.Show("Thêm mới thành công", "THÔNG BÁO");
                this.BindingContext[xpcPublicHoliday].AddNew();
                FrmPublicHoliday f = this.Tag as FrmPublicHoliday;
                f.RefreshData();
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra!", "THÔNG BÁO");
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (LaHopLe() == true)
            {
                Session s = XpoDefault.Session;
                s.Save(xpcPublicHoliday);
                FrmPublicHoliday f = this.Tag as FrmPublicHoliday;
                f.RefreshData();
                XtraMessageBox.Show("Cập nhật thành công", "THÔNG BÁO");
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra!", "THÔNG BÁO");
            }
        }
             
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       private bool LaHopLe()
        {
            er.Clear();
            bool flag = true;
           if(txtTenNgayLe.Text == string.Empty)
           {
               er.SetError(txtTenNgayLe, "Vui lòng nhập tên ngày lễ.");
               flag = false;
           }
           if(dtDenNgay.Text == string.Empty)
           {
               er.SetError(dtDenNgay, "Vui lòng chọn ngày kết thúc.");
               flag = false;
           }
           if(dtTuNgay.Text == string.Empty)
           {
               er.SetError(dtTuNgay, "Vui lòng chọn ngày bắt đầu.");
               flag = false;
           }
           if(DateTime.Compare(dtTuNgay.DateTime,dtDenNgay.DateTime) == 1)
           {
               er.SetError(dtDenNgay, "Ngày kết thúc phải lớn hơn ngày bắt đầu.");
               flag = false;
           }
            return flag;
        }

       private void dtTuNgay_EditValueChanged(object sender, EventArgs e)
       {
           dtDenNgay.EditValue = dtTuNgay.EditValue;
       }
    }
}
