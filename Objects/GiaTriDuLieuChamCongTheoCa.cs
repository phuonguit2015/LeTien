using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class GiaTriDuLieuChamCongTheoCa : XPObject
    {
        public GiaTriDuLieuChamCongTheoCa()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public GiaTriDuLieuChamCongTheoCa(Session session)
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

        [DisplayName("Ca")]
        public DanhMucCa Ca
        {
            get;
            set;
        }

        [DisplayName("Loại Dữ Liệu Chấm Công")]
        public LoaiDuLieuChamCong LoaiDLChamCong
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