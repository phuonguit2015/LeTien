using System;
using DevExpress.Xpo;
using System.Drawing;


namespace LeTien.Objects
{

    public class LoaiDuLieuChamCong : XPObject
    {
        public LoaiDuLieuChamCong()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public LoaiDuLieuChamCong(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        [DisplayName ("Loại chấm công")]
        [Indexed (Unique = true)]
        public string LoaiChamCong
        {
            get;

            set;
        }
      
        public DateTime Thang
        {
            get;
            set;
        }

        #region "Ngày"
        [DisplayName ("Ngày 1")]
        public string Ngay1
        {
            get;
            set;
        }
        [DisplayName("Ngày 2")]
        public string Ngay2
        {
            get;
            set;
        }
        [DisplayName("Ngày 3")]
        public string Ngay3
        {
            get;
            set;
        }
       [DisplayName("Ngày 4")]
        public string Ngay4
        {
            get;
            set;
        }
       [DisplayName("Ngày 5")]
       public string Ngay5
       {
           get;
           set;
       }
       [DisplayName("Ngày 6")]
       public string Ngay6
       {
           get;
           set;
       }
       [DisplayName("Ngày 7")]
       public string Ngay7
       {
           get;
           set;
       }
       [DisplayName("Ngày 8")]
       public string Ngay8
       {
           get;
           set;
       }
       [DisplayName("Ngày 9")]
       public string Ngay9
       {
           get;
           set;
       }
       [DisplayName("Ngày 10")]
       public string Ngay10
       {
           get;
           set;
       }
       [DisplayName("Ngày 11")]
       public string Ngay11
       {
           get;
           set;
       }
       [DisplayName("Ngày 12")]
       public string Ngay12
       {
           get;
           set;
       }
       [DisplayName("Ngày 13")]
       public string Ngay13
       {
           get;
           set;
       }
       [DisplayName("Ngày 14")]
       public string Ngay14
       {
           get;
           set;
       }
       [DisplayName("Ngày 15")]
       public string Ngay15
       {
           get;
           set;
       }
       [DisplayName("Ngày 16")]
       public string Ngay16
       {
           get;
           set;
       }
       [DisplayName("Ngày 17")]
       public string Ngay17
       {
           get;
           set;
       }
       [DisplayName("Ngày 18")]
       public string Ngay18
       {
           get;
           set;
       }
       [DisplayName("Ngày 19")]
       public string Ngay19
       {
           get;
           set;
       }
       [DisplayName("Ngày 20")]
       public string Ngay20
       {
           get;
           set;
       }
       [DisplayName("Ngày 21")]
       public string Ngay21
       {
           get;
           set;
       }
       [DisplayName("Ngày 22")]
       public string Ngay22
       {
           get;
           set;
       }
       [DisplayName("Ngày 23")]
       public string Ngay23
       {
           get;
           set;
       }
       [DisplayName("Ngày 24")]
       public string Ngay24
       {
           get;
           set;
       }
       [DisplayName("Ngày 25")]
       public string Ngay25
       {
           get;
           set;
       }
       [DisplayName("Ngày 26")]
       public string Ngay26
       {
           get;
           set;
       }
       [DisplayName("Ngày 27")]
       public string Ngay27
       {
           get;
           set;
       }
       [DisplayName("Ngày 28")]
       public string Ngay28
       {
           get;
           set;
       }
       [DisplayName("Ngày 29")]
       public string Ngay29
       {
           get;
           set;
       }
       [DisplayName("Ngày 30")]
       public string Ngay30
       {
           get;
           set;
       }
       [DisplayName("Ngày 31")]
       public string Ngay31
       {
           get;
           set;
       }
#endregion

        [DisplayName ("Kiểu dữ liệu")]
        public string KieuDuLieu
        {
            get;
            set;            
        }
        [DisplayName("Ghi chú")]
        public string GhiChu;

        [DisplayName("Giá trị mặc định")]
        public string DuLieuMacDinh
        {
            get;
            set;
        }

       

        [Persistent("MauHienThiDuong")]
        private Int32 _mauHienThiDuong;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiDuong
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiDuong)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị dương")]
        public Color MauHienThiDuong
        {
            get { return Color.FromArgb(_mauHienThiDuong); }
            set
            {
                _mauHienThiDuong = value.ToArgb();
                OnChanged("MauHienThiDuong");
            }   
        }

        [Persistent("MauHienThiAm")]
        private Int32 _mauHienThiAm;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiAm
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiAm)); }
        }


        [DisplayName("Màu hiển thị âm")]
        [NonPersistent]
        public Color MauHienThiAm
        {
            get { return Color.FromArgb(_mauHienThiAm); }
            set
            {
                _mauHienThiAm = value.ToArgb();
                OnChanged("MauHienThiAm");
            }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}