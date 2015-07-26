using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class ThamSo : XPObject
    {
        public ThamSo()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public ThamSo(Session session)
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


        [DisplayName("Tên Tham Số")]
        [Indexed(Unique = true)]
        public string TenThamSo
        {
            get;
            set;
        }

        [DisplayName("Kiểu Dữ Liệu")]
        public string KieuDuLieu
        {
            get;
            set;
        }

        [DisplayName("Giá Trị")]
        public string GiaTri
        {
            get;
            set;
        }
    }

}