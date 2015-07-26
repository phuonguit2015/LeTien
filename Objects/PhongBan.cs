using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class PhongBan : XPObject
    {
        public PhongBan()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PhongBan(Session session)
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
        [DisplayName("Mã Phòng Ban")]
        [Indexed(Unique = true)]
        public string MaPhongBan
        {
            get;
            set;
        }

        [DisplayName("Tên Phòng Ban")]
        public string TenPhongBan
        {
            get;
            set;
        }

        [DisplayName("GhiChu")]
        public string GhiChu
        {
            get;
            set;
        }

    }

}