using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class PublicHoliday : XPObject
    {
        public PublicHoliday()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PublicHoliday(Session session)
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
        [DisplayName ("Ngày Lễ")]
        [Indexed (Unique=true)]
        public string PublicHolidayName;

        [DisplayName ("Ngày Bắt Đầu")]
        public DateTime PublicHolidayStart;

        [DisplayName ("Ngày Kết Thúc")]
        public DateTime PublicHolidayEnd;

        [DisplayName ("Ghi Chú")]
        public string PublicHolidayDescription;
    }

}