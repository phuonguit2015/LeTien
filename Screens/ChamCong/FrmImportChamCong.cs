using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using LeTien.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.Salaries
{
    public partial class FrmImportChamCong : Form
    {
        DataTable dt = new DataTable();
        XPQuery<PublicHoliday> publicHoliday = Session.DefaultSession.Query<PublicHoliday>();
        XPQuery<ThamSo> thamSo = Session.DefaultSession.Query<ThamSo>();


        public FrmImportChamCong()
        {
            InitializeComponent();
            ((System.ComponentModel.ISupportInitialize)(this.xpcLoaiDuLieuChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcGiaTriChamCong)).BeginInit();

            this.xpcLoaiDuLieuChamCong.ObjectType = typeof(LeTien.Objects.LoaiDuLieuChamCong);
            this.xpcNhanVien.ObjectType = typeof(LeTien.Objects.Employee);
            this.xpcGiaTriChamCong.ObjectType = typeof(LeTien.Objects.GiaTriDuLieuChamCongTheoCa);
            ((System.ComponentModel.ISupportInitialize)(this.xpcLoaiDuLieuChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcGiaTriChamCong)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.xpcCa)).BeginInit();
            this.xpcCa.ObjectType = typeof(LeTien.Objects.DanhMucCa);
            ((System.ComponentModel.ISupportInitialize)(this.xpcCa)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.xpcChuKyLuong)).BeginInit();
            this.xpcChuKyLuong.ObjectType = typeof(LeTien.Objects.ChuKyLuongThang);
            ((System.ComponentModel.ISupportInitialize)(this.xpcChuKyLuong)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.xpcChamCong)).BeginInit();
            this.xpcChamCong.ObjectType = typeof(LeTien.Objects.ChamCong);
            ((System.ComponentModel.ISupportInitialize)(this.xpcChamCong)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.xpcChiTietCa)).BeginInit();
            this.xpcChiTietCa.ObjectType = typeof(LeTien.Objects.ChiTietXepCa);
            ((System.ComponentModel.ISupportInitialize)(this.xpcChiTietCa)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.xpcNgayLe)).BeginInit();
            this.xpcNgayLe.ObjectType = typeof(LeTien.Objects.PublicHoliday);
            ((System.ComponentModel.ISupportInitialize)(this.xpcNgayLe)).EndInit();


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.Title = "Select a File Excel";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string urlFile = openFileDialog1.FileName;
                txtBrowse.Text = urlFile;
                LoadData(urlFile);
            }
        }               

        public string GetConnectionString(string excelFileName)
        {
            string strConnectionString = "";
            if (Path.GetExtension(excelFileName).ToLower() == ".xlsx")
                strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", excelFileName);
            else if (Path.GetExtension(excelFileName).ToLower() == ".xls")
                strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", excelFileName);
            return strConnectionString;
        }

        public void LoadData(string excelFileName)
        {
            dt.Clear();

            DataTable temp = new DataTable();
            string cmdText = "select * from [Sheet1$]";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdText, GetConnectionString(excelFileName)))
            {
                adapter.Fill(temp);               
            }

            if (temp.Rows.Count > 0)
            {
                temp.DefaultView.RowFilter = "F3 <> ''";
                temp = temp.DefaultView.ToTable();
            }

            //Fomart cấu trúc bảng
            List<string> dsCol = new List<string>(){"Mã NV", "Ngày", "Vào 1", "Vào 2", "Vào 3",
            "Ra 1", "Ra 2", "Ra 3"};

            foreach(DataRow itemrow in temp.Rows)
            {

                foreach (string col in dsCol)
                {
                    for (int i = 0; i < temp.Columns.Count; i++)
                    {
                        if (itemrow[i].ToString() == col)
                        {                           
                            temp.Columns[i].ColumnName = col;
                        }
                    }
                }
            }

            //Xóa dòng đầu tiền trong bảng
            temp.Rows.RemoveAt(0);


          

            //Đưa về bảng 8 cột
          
            for (int i = 0; i < temp.Columns.Count; i++)
            {
                DataColumn columns = temp.Columns[i];
                foreach (string col in dsCol)
                {
                    if (col == columns.ColumnName && !dt.Columns.Contains(col))
                    {
                        dt.Columns.Add(col);                       
                        break;
                    }
                }
            } 
            
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = temp.Rows[i];
                dt.ImportRow(dr);
            }
          
            
            #region Xử lý dữ liệu
            //Hiện dữ liệu chấm công
           foreach(LoaiDuLieuChamCong l in xpcLoaiDuLieuChamCong)
            {

                if (l.ShowWhenImport)
                {
                    if (!dt.Columns.Contains(l.LoaiChamCong))
                    {
                        dt.Columns.Add(l.LoaiChamCong);
                    }
                    bool b = false;
                    GridColumn col = new GridColumn();
                    col.FieldName = l.LoaiChamCong;
                    col.Caption = l.LoaiChamCong;
                    col.VisibleIndex = gridView1.Columns.Count - 1;
                    foreach (GridColumn c in gridView1.Columns)
                    {
                        if (col.FieldName == c.FieldName)
                        {
                            b = true;
                        }
                    }
                    if (!b)
                    {
                        gridView1.Columns.Add(col);
                    }
                }
            }

            //Thêm cột tương ứng vào datatable
           if (!dt.Columns.Contains("Checked"))
           {
               dt.Columns.Add("Checked", typeof(bool));
           }
           if (!dt.Columns.Contains("Ca"))
           {
               dt.Columns.Add("Ca", typeof(DanhMucCa));
           }
           if (!dt.Columns.Contains("GioVao"))
           {
               dt.Columns.Add("GioVao", typeof(DateTime));
           }
           if (!dt.Columns.Contains("GioRa"))
           {
               dt.Columns.Add("GioRa", typeof(DateTime));
           }
           if (!dt.Columns.Contains("NhanVien"))
           {
               dt.Columns.Add("NhanVien", typeof(Employee));
           }
            //Nếu giờ ra lớn hơn giờ ra Tham Số Thời Gian Phân Biêt Ca
            List<ThamSo> _thamSoThoiGian = (from tso in thamSo
                                            where (tso.TenThamSo == "Thời Gian Tính Tăng Ca Đêm")
                                            select tso).ToList();
            //Thời Gian Nghĩ Giữa Ca (Giờ)
            List<ThamSo> _thamSoNghiGiuaCa = (from tso in thamSo
                                              where (tso.TenThamSo == "Thời Gian Nghỉ Giữa Ca (Giờ)")
                                            select tso).ToList();
            //Ca Không Có Thời Gian Nghỉ
            List<ThamSo> _thamSoCaKhongCoGioNghi = (from tso in thamSo
                                              where (tso.TenThamSo == "Ca Không Có Thời Gian Nghỉ")
                                              select tso).ToList();

            string dsCaKhongCoGioNghi = _thamSoCaKhongCoGioNghi[0].GiaTri;

            //Khoảng Giới Hạn Tăng Ca (Giờ)
            List<ThamSo> _thamSoKhoangGioiHanTangCa= (from tso in thamSo
                                                    where (tso.TenThamSo == "Khoảng Giới Hạn Tăng Ca (Giờ)")
                                                    select tso).ToList();
            double khoangGioiHanTangCa = double.Parse(_thamSoKhoangGioiHanTangCa[0].GiaTri);
            //Gán giờ ra
            for (int i = 0; i < dt.Rows.Count; i++)
            {               
                for (int j = 2; j < 8; j++)
                {
                    if (j == 3 || j == 5 || j == 7)
                    {
                        if (dt.Rows[i][j].ToString() != "" && dt.Rows[i][j] != System.DBNull.Value)
                        {
                            dt.Rows[i]["GioRa"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i][j]));

                        }                        
                    }
                }
                if (dt.Rows[i]["Vào 1"] != System.DBNull.Value)
                {
                    dt.Rows[i]["Vào 1"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i]["Vào 1"]));
                }
                if (dt.Rows[i]["Vào 2"] != System.DBNull.Value)
                {
                    dt.Rows[i]["Vào 2"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i]["Vào 2"]));
                }
                if (dt.Rows[i]["Vào 3"] != System.DBNull.Value)
                {
                    dt.Rows[i]["Vào 3"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i]["Vào 3"]));
                }
                if (dt.Rows[i]["Ra 1"] != System.DBNull.Value)
                {
                    dt.Rows[i]["Ra 1"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i]["Ra 1"]));
                }
                if (dt.Rows[i]["Ra 2"] != System.DBNull.Value)
                {
                    dt.Rows[i]["Ra 2"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i]["Ra 2"]));
                }
                if (dt.Rows[i]["Ra 3"] != System.DBNull.Value)
                {
                    dt.Rows[i]["Ra 3"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i]["Ra 3"]));
                }
                dt.Rows[i]["Ngày"] = DateTime.FromOADate(Convert.ToDouble(dt.Rows[i]["Ngày"]));
                //Load Nhân Viên
                XPCollection nv = new XPCollection(xpcNhanVien, new BinaryOperator("MaNhanVien", dt.Rows[i]["Mã NV"].ToString()));
                if (nv.Count > 0)
                {
                    dt.Rows[i]["NhanVien"] = nv[0];
                }

                

                //Xét ca
                if (dt.Rows[i][2] != System.DBNull.Value)
                {
                    dt.Rows[i]["GioVao"] = DateTime.Parse(dt.Rows[i][2].ToString());
                    foreach (GiaTriDuLieuChamCongTheoCa gt in xpcGiaTriChamCong)
                    {
                        DateTime d1 = DateTime.Parse(dt.Rows[i]["GioVao"].ToString());//Thời gian vào

                        if (gt.LoaiDLChamCong.LoaiChamCong == "Giờ Vào")
                        {
                            DateTime d2 = DateTime.Parse(gt.GiaTri);
                            DateTime d3 = new DateTime(d1.Year, d1.Month, d1.Day, d2.Hour, d2.Minute, d2.Second);
                            TimeSpan t = d1 - d3;
                            if (t.Hours == 0 && t.Minutes > -30 && t.Minutes < 30)
                            {
                                dt.Rows[i]["Ca"] = gt.Ca;
                            }
                        }
                    }
                }

                #region Tính tông thời gian làm và tăng ca, số ngày công
                dt.Rows[i]["Tổng Thời Gian Làm"] = String.Format("{0:0.0}",0);
                dt.Rows[i]["Số Ngày Công"] = 0;
                dt.Rows[i]["Tăng Ca NT"] = String.Format("{0:0.0}", 0);
                dt.Rows[i]["Tăng Ca NT Ca Đêm"] = String.Format("{0:0.0}", 0);
                dt.Rows[i]["Tăng Ca NN"] = String.Format("{0:0.0}", 0);
                dt.Rows[i]["Tăng Ca NN Ca Đêm"] = String.Format("{0:0.0}", 0);
                dt.Rows[i]["Tăng Ca NL"] = String.Format("{0:0.0}", 0);
                dt.Rows[i]["Số Ngày Công Thực Tế"] = 0;

                if (dt.Rows[i]["GioVao"] != System.DBNull.Value && dt.Rows[i]["GioRa"] != System.DBNull.Value)
                {

                    DateTime d1 = DateTime.Parse(dt.Rows[i]["GioVao"].ToString());//Thời gian vào
                    DateTime d2 = DateTime.Parse(dt.Rows[i]["GioRa"].ToString());//Thời gian ra
                    DateTime d3 = new DateTime(d1.Year, d1.Month, d1.Day, d2.Hour, d2.Minute, d2.Second);//Thời gian ra
                    TimeSpan ts = d3 - d1;

                    double hours = ts.Hours + (double)(ts.Minutes) / 60;


                    DateTime dtCurDate = DateTime.Parse(dt.Rows[i]["Ngày"].ToString());//Lấy ngày hiện tại
                    //Kiểm tra ngày lễ
                    List<PublicHoliday> ngayLe = (from nl in publicHoliday
                                                  where (nl.PublicHolidayStart <= dtCurDate && nl.PublicHolidayEnd >= dtCurDate)
                                                  select nl).ToList();
                    if (ngayLe.Count > 0)
                    {
                        dt.Rows[i]["Tăng Ca NL"] = String.Format("{0:0.0}", hours);
                    }
                    //NẾu không phải ngày lễ: ngày thường, ngày nghĩ - Có ca thì ngày thường, không ca thì ngày nghĩ
                    else
                    {
                        
                        //Kiểm tra xem có ca không, nếu có thì so sánh thông tin giá trị mặc định của ca 
                        if (dt.Rows[i]["Ca"] != System.DBNull.Value)
                        {
                            //Lấy tổng thời gian làm mặc định của ca
                            XPCollection xpcGTTCa = new XPCollection(xpcGiaTriChamCong, CriteriaOperator.And(new BinaryOperator("Ca", dt.Rows[i]["Ca"]),
                                new BinaryOperator("LoaiDLChamCong.LoaiChamCong", "Tổng Thời Gian Làm")));
                            if (xpcGTTCa.Count > 0)
                            {
                                double t_TongThoiGianLam = double.Parse((xpcGTTCa[0] as GiaTriDuLieuChamCongTheoCa).GiaTri);
                                double temp_TongThoiGianLam = t_TongThoiGianLam;
                                if (!dsCaKhongCoGioNghi.Contains((xpcGTTCa[0] as GiaTriDuLieuChamCongTheoCa).Ca.TenCa))
                                {
                                    t_TongThoiGianLam += double.Parse(_thamSoNghiGiuaCa[0].GiaTri);
                                }

                                //Nếu thời gian làm lớn hơn tông thời gian làm theo ca->mới tính tăng ca, ngược lại không tính tăng ca
                                if (hours > t_TongThoiGianLam)
                                {
                                    //Nếu giờ ra lớn hơn giờ ra Tham Số Thời Gian Phân Biêt Ca                                  
                                    if (_thamSoThoiGian.Count > 0)
                                    {
                                        DateTime tempTG = DateTime.Parse(_thamSoThoiGian[0].GiaTri);
                                        DateTime thoiGianPhanBietCa = new DateTime(d1.Year, d1.Month, d1.Day, tempTG.Hour, tempTG.Minute, tempTG.Second);
                                        //Nếu thời gian ra lớn hơn thời gian phân biệt ca thì thời gian tăng ca sẻ là tăng ca NT Ca Đêm
                                        TimeSpan ts1 = d3 - thoiGianPhanBietCa;
                                        dt.Rows[i]["Tổng Thời Gian Làm"] = String.Format("{0:0.0}", temp_TongThoiGianLam);
                                        if (ts1.TotalHours > khoangGioiHanTangCa)
                                        {
                                            double dtemp = hours - t_TongThoiGianLam;//Tổng Thời Gian Tăng Ca
                                            dt.Rows[i]["Tăng Ca NT"] = String.Format("{0:0.0}", dtemp - ts1.TotalHours);
                                            dt.Rows[i]["Tăng Ca NT Ca Đêm"] = String.Format("{0:0.0}", ts1.TotalHours);
                                        }
                                        //Ngược lại thời gian tăng ca sẽ là tăng ca NT
                                        else
                                        {
                                            if ((hours - t_TongThoiGianLam) > khoangGioiHanTangCa)
                                            {
                                                dt.Rows[i]["Tăng Ca NT"] = String.Format("{0:0.0}", hours - t_TongThoiGianLam);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    dt.Rows[i]["Tổng Thời Gian Làm"] = String.Format("{0:0.0}", hours);
                                }
                            }
                            dt.Rows[i]["Số Ngày Công"] = 1;
                        }
                        //Ngày nghĩ --- Không có ca
                        else
                        {                            
                            if (_thamSoThoiGian.Count > 0)
                            {
                                DateTime tempTG = DateTime.Parse(_thamSoThoiGian[0].GiaTri);
                                DateTime thoiGianPhanBietCa = new DateTime(d1.Year, d1.Month, d1.Day, tempTG.Hour, tempTG.Minute, tempTG.Second);
                                //Nếu thời gian ra lớn hơn thời gian phân biệt ca thì thời gian tăng ca sẻ là tăng ca NT Ca Đêm
                                TimeSpan ts1 = d3 - thoiGianPhanBietCa;
                                if (ts1.TotalHours > khoangGioiHanTangCa)
                                {
                                    if ((hours - ts1.TotalHours) > khoangGioiHanTangCa)
                                    {
                                        dt.Rows[i]["Tăng Ca NT"] = String.Format("{0:0.0}", hours - ts1.TotalHours);
                                    }
                                    dt.Rows[i]["Tăng Ca NT Ca Đêm"] = String.Format("{0:0.0}", ts1.TotalHours);
                                }
                                else
                                {
                                    if (hours > khoangGioiHanTangCa)
                                    {
                                        dt.Rows[i]["Tăng Ca NT"] = String.Format("{0:0.0}", hours);
                                    }
                                }
                            } 
                        }

                        if(Convert.ToDouble(dt.Rows[i]["Tổng Thời Gian Làm"]) > 0)
                        {
                            dt.Rows[i]["Số Ngày Công Thực Tế"] = 1;
                        }
                    }
                }
                #endregion 

               
            }
            #endregion

            gridControl1.DataSource = dt;
        }             
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dtThangImport.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn tháng.", "Thông Báo");
                return;
            }
           int count = 0;

            string _MaNhanVien = dt.Rows[0]["Mã NV"].ToString();
            ChamCong c = new ChamCong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Checked"] == System.DBNull.Value || Convert.ToBoolean(dt.Rows[i]["Checked"]) == false)
                    continue;
                if (dt.Rows[i]["NhanVien"] == System.DBNull.Value)
                    continue;
                //Lưu thông tin xếp ca
                #region "Xếp Ca"
                ChiTietXepCa ct = new ChiTietXepCa()
                {
                    Ngay = DateTime.Parse(dt.Rows[i]["Ngày"].ToString()),
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    Ca = dt.Rows[i]["Ca"] as DanhMucCa,
                    GhiChu = "",
                    Key = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                if (dt.Rows[i]["Vào 1"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["Vào 1"].ToString());
                    ct.GhiChu += conv.ToShortTimeString();
                }
                if (dt.Rows[i]["Ra 1"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["Ra 1"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["Vào 2"] != System.DBNull.Value)
                {
                    DateTime conv =  DateTime.Parse(dt.Rows[i]["Vào 2"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["Ra 2"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["Ra 2"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["Vào 3"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["Vào 3"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["Ra 3"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["Ra 3"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString() +"\r\n";
                }

                XPCollection xpcCTCa = new XPCollection(xpcChiTietCa, CriteriaOperator.And(new BinaryOperator("Ngay", ct.Ngay),
                    new BinaryOperator("NhanVien", ct.NhanVien)));
                if (xpcCTCa.Count > 0)
                {
                    ChiTietXepCa ct1 = xpcCTCa[0] as ChiTietXepCa;
                    ct1.Ca = ct.Ca;
                    ct1.GhiChu = ct.GhiChu;
                }
                else
                {
                    xpcChiTietCa.Add(ct);
                }
                #endregion
                
                //Lưu Thông tin chấm công
                #region "Chấm Công"

                #region Giờ Vào
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };                
            
                DateTime d = DateTime.Parse(dt.Rows[i]["Ngày"].ToString());
                TimeSpan ts = d - c.FirstDate;
                XPCollection xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Giờ Vào"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                        new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["GioVao"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["GioVao"].ToString();
                        xpcChamCong.Add(c);
                    }

                }
                #endregion

                #region Giờ Ra
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Giờ Ra"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                       new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["GioRa"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["GioRa"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #region Tổng Thời Gian Làm
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Tổng Thời Gian Làm"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                        new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Tổng Thời Gian Làm"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Tổng Thời Gian Làm"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                //Tăng Ca
                //5 Loại Tăng Ca: Tăng Ca NT,Tăng Ca NT Ca Đêm, Tăng Ca NN, Tăng Ca NN Ca Đêm, Tăng Ca Ngày Lễ 
                #region Tăng Ca NT
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Tăng Ca NT"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Tăng Ca NT"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Tăng Ca NT"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #region Tăng Ca NT Ca Đêm
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Tăng Ca NT Ca Đêm"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Tăng Ca NT Ca Đêm"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Tăng Ca NT Ca Đêm"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #region Tăng Ca NN
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Tăng Ca NN"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Tăng Ca NN"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Tăng Ca NN"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #region Tăng Ca NN Ca Đêm
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Tăng Ca NN Ca Đêm"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Tăng Ca NN Ca Đêm"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Tăng Ca NN Ca Đêm"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #region Tăng Ca Ngày Lễ
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Tăng Ca NL"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Tăng Ca NL"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Tăng Ca NL"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #region Số Ngày Công
                // Số Ngày Công
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Số Ngày Công"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Số Ngày Công"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Số Ngày Công"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #region Số Ngày Công Thực Tế
                // Số Ngày Công
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime,
                    TenBangChamCong = dtThangImport.DateTime.Month.ToString() + "-" + dtThangImport.DateTime.Year.ToString()
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Số Ngày Công Thực Tế"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Số Ngày Công Thực Tế"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Số Ngày Công Thực Tế"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

                #endregion

                count++;
            }
            XpoDefault.Session.Save(xpcChamCong);
            XpoDefault.Session.Save(xpcChiTietCa);
            Cursor = Cursors.Default;


            XtraMessageBox.Show(String.Format("Lưu thành công {0} dòng.",count), "Thông Báo");
        }

        private void dtThangImport_EditValueChanged(object sender, EventArgs e)
        {
            XPCollection xpcThang = new XPCollection(xpcChuKyLuong, new BinaryOperator("Thang", new DateTime(dtThangImport.DateTime.Year, dtThangImport.DateTime.Month, 1),
                BinaryOperatorType.Equal));
            if(xpcThang.Count > 0 )
            {
                dtNgayDauThang.EditValue = (xpcThang[0] as ChuKyLuongThang).FirstDate;
                dtNgayCuoiThang.EditValue = (xpcThang[0] as ChuKyLuongThang).LastDate;
            }
            else
            {
                if(XtraMessageBox.Show("Tháng bạn chọn chưa có thông tin cấu hình chu kỳ lương tháng. Nhấn OK để thực hiện cấu hình.","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Form f = new FrmCauHinhChuKyLuong();
                    if(f.ShowDialog() == DialogResult.Cancel)
                    {
                        xpcChuKyLuong.Reload();
                        dtThangImport_EditValueChanged(sender, e);
                    }
                }
            }
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {

            Form f = new FrmCauHinhChuKyLuong();
            f.ShowDialog();

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int j = 0; j < gridView1.RowCount; j++)
            {
                gridView1.SetRowCellValue(j, colChecked, false);

            }
            if (gridView1.SelectedRowsCount > 0)
            {
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    gridView1.SetRowCellValue(gridView1.GetSelectedRows()[i], colChecked, true);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Exel 2013 (*.xls)|*.xls";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = save.FileName;
                gridControl1.ExportToXls(fileName);
            } 
        }


    }
}
