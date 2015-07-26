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


        [DisplayName("Loại Tính Tổng")]
        public string TinhTong
        {
            get;
            set;
        }

        [DisplayName("Đơn Vị Tổng")]
        public string DonViTong
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
        //Chỉ dùng 1 cột màu, 1 cột so sánh

        public bool ShowWhenImport
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