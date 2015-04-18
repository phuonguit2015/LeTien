using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using LeTien.Objects;
using LeTien.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.Salaries
{
    public partial class FrmPhieuChamCong : Form
    {
        object[] giatri;
        public FrmPhieuChamCong()
        {
            InitializeComponent();
        }

        public FrmPhieuChamCong(Employee nv, DateTime dt)
        {
            InitializeComponent();
            dtNgayChamCong.EditValue = dt;
            lkupNhanVien.EditValue = nv;          
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void FrmPhieuChamCong_Load(object sender, EventArgs e)
        {
            gridControl1.ForceInitialize();
            if (giatri == null)
                giatri = new object[xpcLoaiDuLieuChamCong.Count];
           
            DateTime dt = DateTime.Parse(dtNgayChamCong.EditValue.ToString());
            Employee nv = lkupNhanVien.EditValue as Employee;
            DateTime _dt = new DateTime(dt.Year, dt.Month, Global.SoNgayTrongThang(dt.Month, dt.Year));
            XPCollection _xpcChamCong = new XPCollection(xpcChamCong, CriteriaOperator.And(
                new BinaryOperator("NhanVien", nv), new BinaryOperator("Thang", _dt)));

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                object value = null;
                LoaiDuLieuChamCong LoaiDLChamCong = (xpcLoaiDuLieuChamCong.Lookup(int.Parse(gridView1.GetRowCellValue(i, colOid).ToString()))) as LoaiDuLieuChamCong;
                XPCollection _xpc = new XPCollection(_xpcChamCong, new BinaryOperator("LoaiDuLieuChamCong", LoaiDLChamCong));
                if (_xpc.Count > 0)
                {
                    value = (_xpc[0] as ChamCong)[dt.Day];
                    gridView1.SetRowCellValue(i, colGiaTri, value);
                    giatri[i] = value;
                }

            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
          
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //DateTime dt = DateTime.Parse(dtNgayChamCong.EditValue.ToString());
            //Employee nv = lkupNhanVien.EditValue as Employee;
            //DateTime _dt = new DateTime(dt.Year, dt.Month, Global.SoNgayTrongThang(dt.Month, dt.Year));
            //XPCollection _xpcChamCong = new XPCollection(xpcChamCong, CriteriaOperator.And(
            //    new BinaryOperator("NhanVien", nv), new BinaryOperator("Thang", _dt)));

            //for (int i = 0; i < gridView1.DataRowCount - 1; i++)
            //{
            //    object value = null;
            //    LoaiDuLieuChamCong LoaiDLChamCong = (xpcLoaiDuLieuChamCong.Lookup(int.Parse(gridView1.GetRowCellValue(i, colOid).ToString()))) as LoaiDuLieuChamCong;
            //    XPCollection _xpc = new XPCollection(_xpcChamCong, new BinaryOperator("LoaiDuLieuChamCong", LoaiDLChamCong));
            //    if (_xpc.Count > 0)
            //    {
            //        ChamCong c = _xpc[0] as ChamCong;
            //        value = (_xpc[0] as ChamCong)[dt.Day];
            //        gridView1.SetRowCellValue(i, colGiaTri, value);
            //    }

            //}
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (giatri ==null)
                 giatri = new object[xpcLoaiDuLieuChamCong.Count];
            if (e.Column.Caption == "Giá Trị" && e.IsGetData) e.Value = giatri[e.ListSourceRowIndex];
            if (e.Column.Caption == "Giá Trị" && e.IsSetData) giatri[e.ListSourceRowIndex] = e.Value;
        }
    }
}
