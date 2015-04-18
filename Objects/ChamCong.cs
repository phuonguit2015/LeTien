using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class ChamCong : XPObject
    {
        public ChamCong()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public ChamCong(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public string TenBangChamCong
        {
            get;
            set;
        }

        public Employee NhanVien
        {
            get;
            set;
        }


        public DateTime Thang
        {
            get;
            set;
        }

        public LoaiDuLieuChamCong LoaiDuLieuChamCong
        {
            get;
            set;
        }
       
        [DisplayName ("Kết Quả")]
        public string KetQua
        {
            get;
            set;
        }
       

        public string HieuSuat
        {
            get;
            set;
        }

        public string this[int index]
        {

            get
            {
                switch (index)
                {
                    case 1:
                        return Ngay1;
                        break;
                    case 2:
                        return Ngay2;
                        break;
                    case 3:
                        return Ngay3;
                        break;
                    case 4:
                        return Ngay4;
                        break;
                    case 5:
                        return Ngay5;
                        break;
                    case 6:
                        return Ngay6;
                        break;
                    case 7:
                        return Ngay7;
                        break;
                    case 8:
                        return Ngay8;
                        break;
                    case 9:
                        return Ngay9;
                        break;
                    case 10:
                        return Ngay10;
                        break;
                    case 11:
                        return Ngay11;
                        break;
                    case 12:
                        return Ngay12;
                        break;
                    case 13:
                        return Ngay13;
                        break;
                    case 14:
                        return Ngay14;
                        break;
                    case 15:
                        return Ngay15;
                        break;
                    case 16:
                        return Ngay16;
                        break;
                    case 17:
                        return Ngay17;
                        break;
                    case 18:
                        return Ngay18;
                        break;
                    case 19:
                        return Ngay19;
                        break;
                    case 20:
                        return Ngay10;
                        break;
                    case 21:
                        return Ngay21;
                        break;
                    case 22:
                        return Ngay22;
                        break;
                    case 23:
                        return Ngay23;
                        break;
                    case 24:
                        return Ngay24;
                        break;
                    case 25:
                        return Ngay25;
                        break;
                    case 26:
                        return Ngay26;
                        break;
                    case 27:
                        return Ngay27;
                        break;
                    case 28:
                        return Ngay28;
                        break;
                    case 29:
                        return Ngay29;
                        break;
                    case 30:
                        return Ngay30;
                        break;
                    case 31:
                        return Ngay31;
                        break;
                    default:
                        return string.Empty;
                        break;
                }
            }
            set
            {
                switch (index)
                {
                    case 1:
                        Ngay1 = value;
                        break;
                    case 2:
                        Ngay2 = value;
                        break;
                    case 3:
                        Ngay3 = value;
                        break;
                    case 4:
                        Ngay4 = value;
                        break;
                    case 5:
                        Ngay5 = value;
                        break;
                    case 6:
                        Ngay6 = value;
                        break;
                    case 7:
                        Ngay7 = value;
                        break;
                    case 8:
                        Ngay8 = value;
                        break;
                    case 9:
                        Ngay9 = value;
                        break;
                    case 10:
                        Ngay10 = value;
                        break;
                    case 11:
                        Ngay11 = value;
                        break;
                    case 12:
                        Ngay12 = value;
                        break;
                    case 13:
                        Ngay13 = value;
                        break;
                    case 14:
                        Ngay14 = value;
                        break;
                    case 15:
                        Ngay15 = value;
                        break;
                    case 16:
                        Ngay16 = value;
                        break;
                    case 17:
                        Ngay17 = value;
                        break;
                    case 18:
                        Ngay18 = value;
                        break;
                    case 19:
                        Ngay19 = value;
                        break;
                    case 20:
                        Ngay20 = value;
                        break;
                    case 21:
                        Ngay21 = value;
                        break;
                    case 22:
                        Ngay22 = value;
                        break;
                    case 23:
                        Ngay23 = value;
                        break;
                    case 24:
                        Ngay24 = value;
                        break;
                    case 25:
                        Ngay25 = value;
                        break;
                    case 26:
                        Ngay26 = value;
                        break;
                    case 27:
                        Ngay27 = value;
                        break;
                    case 28:
                        Ngay28 = value;
                        break;
                    case 29:
                        Ngay29 = value;
                        break;
                    case 30:
                        Ngay30 = value;
                        break;
                    case 31:
                        Ngay31 = value;
                        break;
                    default:                        
                        break;
                }
            }
        }
        

        #region "Ngày"
        [DisplayName("Ngày 1")]
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


        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}