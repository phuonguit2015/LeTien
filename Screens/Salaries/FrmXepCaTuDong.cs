using DevExpress.Data.Filtering;
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
    public partial class FrmXepCaTuDong : Form
    {       
        ErrorProvider er = new ErrorProvider();
        List<Employee> NhanVien;
        DateTime dt = new DateTime();

        public FrmXepCaTuDong()
        {
            InitializeComponent();
        }
        public FrmXepCaTuDong(List<Employee>  NhanVien, DateTime dt)
        {
            InitializeComponent();
            this.NhanVien = NhanVien;
            this.dt = dt;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXepCa_Click(object sender, EventArgs e)
        {
            er.Clear();
            if (lkupDanhSachCa.EditValue == null)
            {
                er.SetError(lkupDanhSachCa, "Chưa chọn danh mục ca.");
                return;
            }
            TaoBangXepCa(NhanVien,dt);
            MessageBox.Show("Xếp Ca Thành Công.", "Thông Báo");
            this.Close();
        }
        public void TaoBangXepCa(List<Employee> dsNV, DateTime dt)
        {
            //Tạo bảng xếp ca
            foreach (Employee e in dsNV)
            {
                //XepCa xepCa = new XepCa();
                //xepCa.Thang = dt;

                //xepCa.Ngay1 = int.Parse(lkupDanhSachCa.EditValue.ToString());
                //for (int i = 1; i <= 31; i++)
                //{
                //    xepCa[i] = int.Parse(lkupDanhSachCa.EditValue.ToString());
                //}
                ////Ngày chủ nhật không xếp ca
                //foreach (int item in DanhSachNgayChuNhat(dt))
                //{
                //    for (int i = 1; i <= 31; i++)
                //    {
                //        if (item == i)
                //        {
                //            xepCa[i] = -1;
                //        }
                //    }
                //}
                //xpcXepCa.Add(xepCa);
            }
            XpoDefault.Session.Save(xpcXepCa);


        }

        private void LayDanhMucCa()
        {
            lkupDanhSachCa.Properties.DataSource = xpcDanhMucCa;
            lkupDanhSachCa.Properties.ValueMember = "Oid";
            lkupDanhSachCa.Properties.DisplayMember = "TenCa";
        }

        public List<int> DanhSachNgayChuNhat(DateTime dt)
        {
            List<int> danhSach = new List<int>();
            int i = 1;
            int maxDate = SoNgayTrongThang(dt.Month, dt.Year);
            for (i = 1; i <= maxDate; i++)
            {

                DateTime curDate = new DateTime(dt.Year, dt.Month, i);
                if (curDate.DayOfWeek.ToString() == "Sunday")
                {
                    danhSach.Add(i);
                }
            }
            return danhSach;
        }
              
        

        private int SoNgayTrongThang(int month, int year)
        {
            int daysInMonth;

            DateTime now = DateTime.Now;

            if (month == 0 || year == 0)
            {

                daysInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
            }
            else
            {
                daysInMonth = System.DateTime.DaysInMonth(year, month);
            }
            return daysInMonth;
        }

        private void FrmXepCaTuDong_Load(object sender, EventArgs e)
        {
            LayDanhMucCa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
