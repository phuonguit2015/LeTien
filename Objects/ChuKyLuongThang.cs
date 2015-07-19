using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class ChuKyLuongThang : XPObject
    {
        public ChuKyLuongThang()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public ChuKyLuongThang(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        [DisplayName("Tháng")]
        [Indexed (Unique=true)]
        public DateTime Thang
        {
            get;
            set;
        }

        [DisplayName("Ngày Đầu Tháng")]
        public DateTime FirstDate
        {
            get;
            set;
        }

        [DisplayName("Ngày Cuối Tháng")]
        public DateTime LastDate
        {
            get;
            set;
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}