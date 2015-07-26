using System;
using DevExpress.Xpo;
using System.Drawing;
using DevExpress.Xpo.Metadata;

namespace LeTien.Objects
{

    public class Employee : XPObject
    {
        public Employee()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Employee(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        [DisplayName ("Mã Nhân Viên")]
        [Indexed (Unique=true)]
        public string MaNhanVien
        {
            get;
            set;
        }

        [DisplayName ("Họ Tên")]
        public string Ho
        {
            get;
            set;
        }

        [DisplayName("Tên")]
        public string Ten
        {
            get;
            set;
        }

        [DisplayName("Phòng Ban")]
        public PhongBan phongBan
        {
            get;
            set;
        }

        [DisplayName("Họ và Tên")]
        public string HoTen
        {
            get { return string.Format("{0} {1}", Ho, Ten); }
        }

        [DisplayName ("Tên Tiếng Nhật")]
        public string TenTiengNhat
        {
            get;
            set;
        }

        [DisplayName ("Giới Tính")]
        public string iGioiTinh
        {
            get;
            set;
        }

        
        //private byte[] _anh;
        //[DisplayName("Hình Ảnh")]
        //public byte[] Anh
        //{
        //    get { return _anh; }
        //    set { SetPropertyValue<byte[]>("Anh", ref _anh, value); }
        //}

        private Image _anh;
        [DisplayName("Hình Ảnh")]
        [ValueConverter(typeof(ImageValueConverter))]
        public Image Anh
        {
            get { return _anh; }
            set { SetPropertyValue("Anh", ref _anh, value); }
        }
        [DisplayName ("Ngày Sinh")]
        public DateTime NgaySinh
        {
            get;
            set;
        }

        [DisplayName ("Nơi Sinh")]
        public string NoiSinh
        {
            get;
            set;
        }

        [DisplayName ("Số CMND")]
        public string SoCMND
        {
            get;
            set;
        }

        [DisplayName ("Ngày Cấp")]
        public DateTime NgayCapCMND
        {
            get;
            set;
        }

        [DisplayName ("Nơi Cấp")]
        public string NoiCapCMND
        {
            get;
            set;
        }

        [DisplayName ("Địa Chỉ Thường Trú")]
        public string DiaChiThuongTru
        {
            get;
            set;
        }
        
        [DisplayName ("Địa chỉ tạm trú")]
        public string DiaChiTamTru
        {
            get;
            set;
        }


        [DisplayName ("Số Điện Thoại")]
        public string SoDienThoai
        {
            get;
            set;
        }

        [DisplayName ("Số Tài Khoản Ngân Hàng")]
        public string SoTaiKhoan
        {
            get;
            set;
        }

        [DisplayName ("Tôn Giáo")]
        public Religion TonGiao
        {
            get;
            set;
        }
      
        [DisplayName ("Chức Vụ")]
        public Competence ChucVu
        {
            get;
            set;
        }     

     
        [DisplayName ("Ngày Vào Làm")]
        public DateTime NgayVaoLam
        {
            get;
            set;
        }

       
        [DisplayName ("Số BHXH")]
        public string SoBHXH
        {
            get;
            set;
        }


        [DisplayName ("Ngày Vào BHXH")]
        public DateTime NgayVaoBHXH
        {
            get;
            set;
        }


        [DisplayName ("Hợp đồng")]
        public LaborContract HopDong
        {
           get;
           set;
        }


        [DisplayName ("Lương Cơ Bản")]
        public decimal LuongCoBan
        {
            get;
            set;
        }

        
        [DisplayName ("Chi Nhánh")]
        public Branch ChiNhanh
        {
            get;
            set;
        }


        [DisplayName ("Tình Trạng Hợp Đồng")]
        public string TinhTrangHopDong
        {
            get;
            set;
        }


        [DisplayName ("Lương Đóng BHXH")]
        public string LuongDongBHXH
        {
            get;
            set;
        }

        //public Attendance attendance
        //{
        //    get;
        //    set;
        //}
        //25
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        
    }

}