using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LeTien.Objects;
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
    public partial class FrmXepCa : FormBase
    {
        public FrmXepCa()
        {
            InitializeComponent();
        }


        private string _id = string.Empty;

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                _id = grvUCList.GetRowCellValue(e.RowHandle, "Oid").ToString();
            }
        }


        #region "Override FromBase"
        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                XepCa br = uow.FindObject<XepCa>(CriteriaOperator.Parse("Oid = ?", _id));
                if (br != null)
                {
                    br.Delete();
                    uow.CommitChanges();
                    uow.PurgeDeletedObjects();
                    RefreshData();
                }
            }
        }
        protected override void OnReload()
        {
            UOW.ReloadChangedObjects();
            xpcXepCa.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách xếp ca";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách xếp ca";
            base.OnExportXls();
        }

        #endregion




        public void RefreshData()
        {
            OnReload();
        }

       

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnPreview();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát của sổ làm việc không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvUCList.OptionsBehavior.ReadOnly)
            {
                btnEdit.Caption = "Đang ở chế độ chỉnh sửa";
                grvUCList.OptionsBehavior.ReadOnly = false;
                grvUCList.OptionsBehavior.Editable = true;
            }
            else
            {
                grvUCList.OptionsBehavior.Editable = false;
                grvUCList.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "Đang ở Chế độ chỉ đọc";
            }
        }

        private void btnTaoBangXepCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dtItemThang.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn tháng.");
                return;
            }
            Form f = new FrmTaoBangXepCa(DateTime.Parse(dtItemThang.EditValue.ToString()));
            f.Tag = this;
            f.ShowDialog();
        }

        private XPCollection HienThiDanhSachTheoThang(DateTime dt)
        {
            DateTime minDate = new DateTime(dt.Year, dt.Month, 1);
            DateTime maxDate = new DateTime(dt.Year, dt.Month, SoNgayTrongThang(dt.Month, dt.Year));

            XPCollection _xpcXepCa = new XPCollection(xpcXepCa, CriteriaOperator.And(new BinaryOperator("Ngay", minDate, BinaryOperatorType.GreaterOrEqual),
                new BinaryOperator("Ngay", maxDate, BinaryOperatorType.LessOrEqual)));
            return _xpcXepCa;
        }

        private void dtItemThang_EditValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dtItemThang.EditValue.ToString());
           

            gridUCList.DataSource = HienThiDanhSachTheoThang(dt);
        }
        private int SoNgayTrongThang(int m, int y)
        {
            int daysInMonth;

            DateTime now = DateTime.Now;

            if (m == 0 || y == 0)
            {

                daysInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
                m = now.Month;
                y = now.Year;
            }
            else
            {
                daysInMonth = System.DateTime.DaysInMonth(y, m);
            }
            return daysInMonth;
        }
    }
}
