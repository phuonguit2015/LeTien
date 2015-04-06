using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class LaborContract : XPObject
    {
        public LaborContract()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public LaborContract(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        [DisplayName("Nhân Viên")]
        public Employee NhanVien
        {
            get;
            set;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }


        [DisplayName("Mã Hợp Đồng")]
        [Indexed(Unique = true)]
        public string MaHopDong;

        [DisplayName("Loại Hợp Đồng")]
        public string LoaiHopDong;

        [DisplayName ("Nhân Viên")]
        public Employee iNhanVien
        {
            get;
            set;
        }


        [DisplayName ("Chức Vụ")]
        public Competence ChucVu
        {
            get;
            set;
        }

        [DisplayName ("Lương Cơ Bản")]
        public decimal LuongCoBan
        {
            get;
            set;
        }

        [DisplayName("Ngày Ký")]
        public DateTime NgayKy;

        [DisplayName("Ngày Hết Hạn")]
        public DateTime NgayHetHan;
    }

}