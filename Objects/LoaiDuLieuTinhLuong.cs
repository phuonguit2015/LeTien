using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class LoaiDuLieuTinhLuong : XPObject
    {
        public LoaiDuLieuTinhLuong()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public LoaiDuLieuTinhLuong(Session session)
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

        [DisplayName("Mục Tiền Lương")]
        [Indexed (Unique=true)]
        public string TenLoaiDuLieu
        {
            get;
            set;
        }      

        [DisplayName("Nhóm Dữ Liệu Tính Lương ")]
        public string NhomDuLieu
        {
            get;
            set;
        }
       
        [DisplayName("Giá trị mặc định")]
        public string GiaTriMacDinh
        {
            get;
            set;
        }

        public LoaiDuLieuChamCong LoaiDLChamCong
        {
            get;
            set;
        }

        public string CongThuc
        {
            get;
            set;
        }
        

        [DisplayName ("Theo Chức Vụ")]
        public bool NhomChucVu
        {
            get;
            set;
        }
        
        public long STT
        {
            get;
            set;
        }
   }

}