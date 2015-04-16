using System;
using DevExpress.Xpo;
using System.Drawing;

namespace LeTien.Objects
{

    public class DanhMucCa : XPObject
    {
        public DanhMucCa()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public DanhMucCa(Session session)
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

        [DisplayName("Tên Ca")]
        public string TenCa
        {
            get;
            set;
        }

        [DisplayName("Mô Tả")]
        public string MoTa
        {
            get;
            set;
        }

        [Persistent("MauHienThiCa")]
        private Int32 _mauHienThiCa;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiCa
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiCa)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị ca")]
        public Color MauHienThiCa
        {
            get { return Color.FromArgb(_mauHienThiCa); }
            set
            {
                _mauHienThiCa = value.ToArgb();
                OnChanged("MauHienThiCa");
            }
        }
    }

}