using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class AdvancePayment : XPObject
    {
        public AdvancePayment()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public AdvancePayment(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }


        [DisplayName ("Ngày Tạm Ứng")]
        public DateTime NgayTamUng
        {
            get;
            set;
        }


        [DisplayName ("Nhân Viên")]
        public Employee NhanVien
        {
            get;
            set;
        }

        [DisplayName ("Số Tiền")]
        public decimal SoTien
        {
            get;
            set;
        }


        [DisplayName ("Tháng Tạm Ứng")]
        public DateTime ThangTamUng
        {
            get;
            set;
        }

        [DisplayName ("Mã Phiếu Tạm Ứng")]
        public string MaPhieuTamUng
        {
            get;
            set;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        //[DisplayName("Nhân Viên")]
        //public NhanVien NhanVien;
  
        //[DisplayName("Ngày Tạm Ứng")]
        //public 
    }

}