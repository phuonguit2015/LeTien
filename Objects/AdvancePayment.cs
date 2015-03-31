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

        public DateTime NgayTamUng
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Employee NhanVien
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public decimal SoTien
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime ThangTamUng
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string MaPhieuTamUng
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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