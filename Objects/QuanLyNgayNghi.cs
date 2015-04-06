using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class QuanLyNgayNghi : XPObject
    {
        public QuanLyNgayNghi()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public QuanLyNgayNghi(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        [DisplayName("Nhân Viên")]
        public Employee NhanVien
        {
            get;
            set;
        }


        [DisplayName("Ngày Bắt Đầu")]
        [Indexed (Unique = true)]
        public DateTime NgayBatDau
        {
            get;
            set;
        }

        [DisplayName("Ngày Kết Thúc")]
        public DateTime NgayKetThuc
        {
            get;
            set;
        }


        [DisplayName("Loại Ngày Nghĩ")]
        public DanhMucMauNgayNghiLe LoaiNgayNghi
        {
            get;
            set;
        }
    }

}