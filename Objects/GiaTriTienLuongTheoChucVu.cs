using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class GiaTriTienLuongTheoChucVu : XPObject
    {
        public GiaTriTienLuongTheoChucVu()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public GiaTriTienLuongTheoChucVu(Session session)
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

        [DisplayName("Chức Vụ")]
        public Competence ChucVu
        {
            get;
            set;
        }

        [DisplayName ("Mục Tiền Lương")]
        public LoaiDuLieuTinhLuong MucTienLuong
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