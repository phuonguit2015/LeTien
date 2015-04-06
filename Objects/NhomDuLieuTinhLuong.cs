using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class NhomDuLieuTinhLuong : XPObject
    {
        public NhomDuLieuTinhLuong()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public NhomDuLieuTinhLuong(Session session)
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

        
    }

}