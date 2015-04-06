using System;
using DevExpress.Xpo;
using System.Drawing;

namespace LeTien.Objects
{

    public class ThamSo : XPObject
    {
        public static DevExpress.Xpo.DB.SelectedData LayTatCaThamSo(Session session)
        {
            return session.ExecuteQuery("SELECT * FROM `ThamSo`");
        }
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
        #region "Nghĩ không phép"
        [Persistent("MauHienThiNghiKhongPhep")]
        private Int32 _mauHienThiNghiKhongPhep;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiKhongPhep
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiNghiKhongPhep)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị nghĩ không phép")]
        public Color MauHienThiNghiKhongPhep
        {
            get { return Color.FromArgb(_mauHienThiNghiKhongPhep); }
            set
            {
                _mauHienThiNghiKhongPhep = value.ToArgb();
                OnChanged("MauHienThiNghiKhongPhep");
            }
        }
        #endregion


        #region "Nghĩ có phép"
        [Persistent("MauHienThiNghiCoPhep")]
        private Int32 _mauHienThiNghiCoPhep;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiCoPhep
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiNghiCoPhep)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị nghĩ có phép")]
        public Color MauHienThiNghiCoPhep
        {
            get { return Color.FromArgb(_mauHienThiNghiCoPhep); }
            set
            {
                _mauHienThiNghiCoPhep = value.ToArgb();
                OnChanged("MauHienThiNghiCoPhep");
            }
        }
        #endregion


        #region "Nghĩ chế độ"
        [Persistent("MauHienThiNghiCheDo")]
        private Int32 _mauHienThiNghiCheDo;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiCheDo
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiNghiCheDo)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị nghĩ chế độ")]
        public Color MauHienThiNghiCheDo
        {
            get { return Color.FromArgb(_mauHienThiNghiCheDo); }
            set
            {
                _mauHienThiNghiCheDo = value.ToArgb();
                OnChanged("MauHienThiNghiCheDo");
            }
        }
        #endregion


        #region "Đi trể"
        [Persistent("MauHienThiDiTre")]
        private Int32 _mauHienThiDiTre;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiDiTre
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiDiTre)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị đi trể")]
        public Color MauHienThiDiTre
        {
            get { return Color.FromArgb(_mauHienThiDiTre); }
            set
            {
                _mauHienThiDiTre = value.ToArgb();
                OnChanged("MauHienThiDiTre");
            }
        }
        #endregion


        #region "Về sớm"
        [Persistent("MauHienThiVeSom")]
        private Int32 _mauHienThiVeSom;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiVeSom
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiVeSom)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị về sớm")]
        public Color MauHienThiVeSom
        {
            get { return Color.FromArgb(_mauHienThiVeSom); }
            set
            {
                _mauHienThiVeSom = value.ToArgb();
                OnChanged("MauHienThiVeSom");
            }
        }
        #endregion


        #region "Ngày lễ"
        [Persistent("MauHienThiNgayNghiLe")]
        private Int32 _mauHienThiNgayNghiLe;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiNgayNghiLe
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiNgayNghiLe)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị ngày nghĩ lễ")]
        public Color MauHienThiNgayNghiLe
        {
            get { return Color.FromArgb(_mauHienThiNgayNghiLe); }
            set
            {
                _mauHienThiNgayNghiLe = value.ToArgb();
                OnChanged("MauHienThiNgayNghiLe");
            }
        }
        #endregion


        #region "Ngày chủ nhật"
        [Persistent("MauHienThiNgayChuNhat")]
        private Int32 _mauHienThiNgayChuNhat;
        [NonPersistent, System.ComponentModel.Browsable(false)]
        public Int32 OleMauHienThiNgayChuNhat
        {
            get { return ColorTranslator.ToOle(Color.FromArgb(_mauHienThiNgayChuNhat)); }
        }

        [NonPersistent]
        [DisplayName("Màu hiển thị ngày chủ nhật")]
        public Color MauHienThiNgayChuNhat
        {
            get { return Color.FromArgb(_mauHienThiNgayChuNhat); }
            set
            {
                _mauHienThiNgayChuNhat = value.ToArgb();
                OnChanged("MauHienThiNgayChuNhat");
            }
        }
        #endregion



    }

}