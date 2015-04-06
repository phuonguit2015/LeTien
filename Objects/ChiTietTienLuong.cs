using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class ChiTietTienLuong : XPObject
    {
        public ChiTietTienLuong()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public ChiTietTienLuong(Session session)
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
        [DisplayName("Tháng")]
        public DateTime Thang
        {
            get;
            set;
        }

        [DisplayName("Nhân Viên")]
        public Employee NhanVien
        {
            get;
            set;
        }

        [DisplayName("Mục Tiền Lương")]
        public LoaiDuLieuTinhLuong LoaiDLTinhLuong
        {
            get;
            set;
        }

        [DisplayName("Giá Trị")]
        public decimal GiaTri
        {
            get;
            set;
        }
    }

}