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
            string cmdText = "select * from [Sheet1$]";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdText, GetConnectionString(excelFileName)))
            {
                adapter.Fill(dt);               
            }
            //Hiện dữ liệu chấm công
            foreach(LoaiDuLieuChamCong l in xpcLoaiDuLieuChamCong)
            {

                if (l.ShowWhenImport)
                {
                    dt.Columns.Add(l.LoaiChamCong);
                    GridColumn col = new GridColumn();
                    col.FieldName = l.LoaiChamCong;
                    col.Caption = l.LoaiChamCong;
                    col.VisibleIndex = gridView1.Columns.Count - 1;
                    gridView1.Columns.Add(col);
                }
            }
            dt.Columns.Add("Ca", typeof(DanhMucCa));
            dt.Columns.Add("GioVao", typeof(DateTime));
            dt.Columns.Add("GioRa", typeof(DateTime));
            dt.Columns.Add("NhanVien", typeof(Employee));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double d;
                for (int j = 2; j < 8; j++)
                {
                    if (double.TryParse(dt.Rows[i][j].ToString(), out d))
                    {
                        DateTime conv = DateTime.FromOADate(d);
                        dt.Rows[i][j] = conv;
                        if (j == 3 || j == 5 || j == 7)
                        {
                            dt.Rows[i]["GioRa"] = dt.Rows[i][j];
                        }
                    }
                }
                //Load Nhân Viên
                XPCollection nv = new XPCollection(xpcNhanVien, new BinaryOperator("MaNhanVien", dt.Rows[i]["MaNhanVien"].ToString()));
                if (nv.Count > 0)
                {
                    dt.Rows[i]["NhanVien"] = nv[0];
                }
                //Xét ca
                if (dt.Rows[i][2] != System.DBNull.Value)
                {
                    dt.Rows[i]["GioVao"] = dt.Rows[i][2];
                    foreach (GiaTriDuLieuChamCongTheoCa gt in xpcGiaTriChamCong)
                    {                        
                        DateTime d1 = DateTime.Parse(dt.Rows[i]["GioVao"].ToString());//Thời gian vào
                        
                        if(gt.LoaiDLChamCong.LoaiChamCong == "Thời Gian Vào")
                        {
                            DateTime d2 = DateTime.Parse(gt.GiaTri.ToString());
                            DateTime d3 = new DateTime(d1.Year, d1.Month, d1.Day, d2.Hour, d2.Minute, d2.Second);
                            TimeSpan t = d1 - d3;
                            if(t.Hours == 0 && t.Minutes > -30 && t.Minutes < 30)
                            {
                                dt.Rows[i]["Ca"] = gt.Ca;                                
                            }
                        }                       
                    }
                    foreach (GiaTriDuLieuChamCongTheoCa gt in xpcGiaTriChamCong)
                    {
                        if (gt.LoaiDLChamCong.LoaiChamCong == "Tổng Thời Gian Làm" && gt.Ca == dt.Rows[i]["Ca"])
                        {
                            dt.Rows[i]["Tổng Thời Gian Làm"] = gt.GiaTri;
                        }
                    }
                    if (dt.Rows[i]["GioRa"] != System.DBNull.Value)
                    {
                            DateTime d1 = DateTime.Parse(dt.Rows[i]["GioVao"].ToString());//Thời gian vào
                            DateTime d2 = DateTime.Parse(dt.Rows[i]["GioRa"].ToString());//Thời gian ra
                            DateTime d3 = new DateTime(d1.Year, d1.Month, d1.Day, d2.Hour, d2.Minute, d2.Second);

                            TimeSpan t = d3 - d1;
                            TimeSpan t2 = new TimeSpan(int.Parse(dt.Rows[i]["Tổng Thời Gian Làm"].ToString()),0,0);
                        dt.Rows[i]["Tăng Ca"] = String.Format("{0:0.00}", (t - t2).TotalHours);
                    }
                }
            }           

           gridControl1.DataSource = dt;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dtThangImport.EditValue == System.DBNull.Value)
            {
                XtraMessageBox.Show("Bạn chưa chọn tháng.", "Thông Báo");
                return;
            }

            string _MaNhanVien = dt.Rows[0]["MaNhanVien"].ToString();
            ChamCong c = new ChamCong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Lưu thông tin xếp ca
                #region "Xếp Ca"
                ChiTietXepCa ct = new ChiTietXepCa()
                {
                    Ngay = DateTime.Parse(dt.Rows[i]["Ngay"].ToString()),
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    Ca = dt.Rows[i]["Ca"] as DanhMucCa,
                    GhiChu = "",

                };
                double giovaora;

                if (dt.Rows[i]["GioVao1"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["GioVao1"].ToString());
                    ct.GhiChu += conv.ToShortTimeString();
                }
                if (dt.Rows[i]["GioRa1"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["GioRa1"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["GioVao2"] != System.DBNull.Value)
                {
                    DateTime conv =  DateTime.Parse(dt.Rows[i]["GioVao2"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["GioRa2"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["GioRa2"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["GioVao3"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["GioVao3"].ToString());
                    ct.GhiChu += "|" + conv.ToShortTimeString();
                }
                if (dt.Rows[i]["GioRa3"] != System.DBNull.Value)
                {
                    DateTime conv = DateTime.Parse(dt.Rows[i]["GioRa3"].ToString());
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
                XpoDefault.Session.Save(xpcChiTietCa);
                #endregion

                //Lưu Thông tin chấm công
                #region "Chấm Công"
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime
                };

                DateTime d = DateTime.Parse(dt.Rows[i]["Ngay"].ToString());
                TimeSpan ts = d - c.FirstDate;
                XPCollection xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Thời Gian Vào"));
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

                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Thời Gian Ra"));
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


                //
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime
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

                //
                c = new ChamCong()
                {
                    Thang = dtThangImport.DateTime,
                    NhanVien = dt.Rows[i]["NhanVien"] as Employee,
                    FirstDate = dtNgayDauThang.DateTime,
                    LastDate = dtNgayCuoiThang.DateTime
                };
                xpcLoaiDLChamCong = new XPCollection(xpcLoaiDuLieuChamCong, new BinaryOperator("LoaiChamCong", "Tăng Ca"));
                if (xpcLoaiDLChamCong.Count > 0)
                {
                    c.LoaiDuLieuChamCong = xpcLoaiDLChamCong[0] as LoaiDuLieuChamCong;
                    XPCollection xpcCC = new XPCollection(xpcChamCong, CriteriaOperator.And(new BinaryOperator("NhanVien", c.NhanVien),
                         new BinaryOperator("Thang", c.Thang), new BinaryOperator("LoaiDuLieuChamCong", c.LoaiDuLieuChamCong)));
                    if (xpcCC.Count > 0)
                    {
                        ChamCong c1 = xpcCC[0] as ChamCong;
                        c1[ts.Days + 1] = dt.Rows[i]["Tăng Ca"].ToString();
                    }
                    else
                    {
                        c[ts.Days + 1] = dt.Rows[i]["Tăng Ca"].ToString();
                        xpcChamCong.Add(c);
                    }
                }
                #endregion

            }
            XpoDefault.Session.Save(xpcChamCong);




            XtraMessageBox.Show("Lưu thành công.", "Thông Báo");
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


    }
}
