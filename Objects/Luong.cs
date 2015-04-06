using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class Luong : XPObject
    {
        public Luong()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Luong(Session session)
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


        [DisplayName("Nhân Viên")]
        [Indexed(Unique = true)]
        public Employee NhanVien
        {
            get;
            set;
        }

        [DisplayName("Số Ngày Làm Việc Trong Tháng")]
        public int SoNgayLamViec
        {
            get;
            set;
        }

        [DisplayName ("Số Giờ Làm Việc Trong Tháng")]
        public int SoGioLamViec
        {
            get;
            set;
        }

        [DisplayName("Trợ Cấp Chức Vụ")]
        public string TroCapChucVu
        {
            get;
            set;
        }

        [DisplayName("Chuyên Cần")]
        public string ChuyenCan
        {
            get;
            set;
        }

        [DisplayName("Cơm Thường")]
        public string ComThuong
        {
            get;
            set;
        }

        [DisplayName("Cơm Tăng Ca")]
        public string ComTangCa
        {
            get;
            set;
        }


        [DisplayName("Tăng Ca 1.5")]
        public string TangCa15
        {
            get;
            set;
        }

        [DisplayName("Tăng Ca 2.0")]
        public string TangCa20
        {
            get;
            set;
        }


        [DisplayName("Tăng Ca 2.0 + 1.3")]
        public string TangCa2013
        {
            get;
            set;
        }


        [DisplayName("Tăng Ca 3.0")]
        public string TangCa30
        {
            get;
            set;
        }

        [DisplayName("Tăng Ca 3.0 + 1.3")]
        public string TangCa3013
        {
            get;
            set;
        }

        [DisplayName("Độc Hại")]
        public string DocHai
        {
            get;
            set;
        }

        [DisplayName("Đi Công Tác(Về + Trọ)")]
        public string CongTac
        {
            get;
            set;
        }

        [DisplayName("Chi Phí Đi Lại")]
        public string ChiPhiDiLai
        {
            get;
            set;
        }

        [DisplayName("Phụ Cấp Khác")]
        public string PhuCapKhac
        {
            get;
            set;
        }

        [DisplayName("Tổng Số Phụ Cấp")]
        public string TongPhuCap
        {
            get;
            set;
        }

        [DisplayName("Bảo Hiểm Công Ty Trả")]
        public string BaoHiemCtyTra
        {
            get;
            set;
        }

        [DisplayName("Công Đoàn Công Ty Trả")]
        public string CongDoanCtyTra
        {
            get;
            set;
        }

        [DisplayName("Khấu Trừ/Vắng Mặt")]
        public string KhauTruVangMat
        {
            get;
            set;
        }

        [DisplayName("Tổng Số Tiền")]
        public string TongSoTien
        {
            get;
            set;
        }

        [DisplayName("Bảo Hiểm Cá Nhân Đóng")]
        public string BaoHiemCaNhanDong
        {
            get;
            set;
        }

        [DisplayName("Công Đoàn Cá Nhân Đóng")]
        public string CongDoanCaNhanDong
        {
            get;
            set;
        }


        [DisplayName("Tổng Thu Nhập")]
        public string TongThuNhap
        {
            get;
            set;
        }


        [DisplayName("Tạm Ứng")]
        public string TamUng
        {
            get;
            set;
        }

        [DisplayName("Bảo Hiểm + Đồng Phục")]
        public string BaoHiemDongPhuc
        {
            get;
            set;
        }


        [DisplayName("Tác Phong")]
        public string TacPhong
        {
            get;
            set;
        }


        [DisplayName("Khoản Trừ 3%, 5%")]
        public string KhoanTru35
        {
            get;
            set;
        }


        [DisplayName ("Tổng Thực Lãnh")]
        public string TongThucLanh
        {
            get;
            set;
        }
    }

}