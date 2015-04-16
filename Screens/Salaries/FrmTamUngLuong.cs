using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmTamUngLuong : FormBase
    {
        private string _Oid = string.Empty;
        public FrmTamUngLuong()
        {
            InitializeComponent();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new MyLocalizer();
        }
        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                AdvancePayment br = uow.FindObject<AdvancePayment>(CriteriaOperator.Parse("Oid = ?", _Oid));
                if (br != null)
                {
                    br.Delete();
                    uow.CommitChanges();
                    uow.PurgeDeletedObjects();
                    OnReload();
                }
            }
        }

        protected override void OnReload()
        {
            UOW.ReloadChangedObjects();
            xpcTamUngLuong.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách tạm ứng lương";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách tạm ứng lương";
            base.OnExportXls();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExportXls();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //// Create a report. 
            //XtraReport report = XtraReport.FromFile(@".\\Reports\\DataReport-QLngaynghi.repx", true);
            //report.DataSource = xpcQuanLyNgayNghi;

            ////OnPreview();
            //ReportPrintTool pt = new ReportPrintTool(report);
            //pt.AutoShowParametersPanel = true;
            //pt.ShowPreviewDialog();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
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

        private void grvUCList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grvUCList.GetRowCellDisplayText(e.RowHandle, "Oid") == string.Empty) return;
            _Oid = grvUCList.GetRowCellDisplayText(e.RowHandle, "Oid");
            btnXoa.Enabled = true;
        }

        private void grvUCList_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow r = grvUCList.GetFocusedDataRow();
            ColumnView view = sender as ColumnView;
            GridColumn column1 = view.Columns["SoTien"];
            string str = view.GetRowCellValue(e.RowHandle,column1).ToString();            
            if (decimal.Parse(str) > 1000000 || decimal.Parse(str) < 500000)
            {
                e.Valid = false;
                view.SetColumnError(view.Columns["SoTien"], "Tiền tạm ứng tối thiểu là 500000, tối đa là 1000000");
            }


        }

        private void grvUCList_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void grvUCList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //if(e.Column.FieldName == "NgayTamUng" || e.Column.FieldName == "NhanVien!")
            //{
            //    try
            //    {
            //        DataRow r = grvUCList.GetFocusedDataRow();
            //        ColumnView view = sender as ColumnView;
            //        DateTime dt = DateTime.Parse(view.GetRowCellDisplayText(e.RowHandle, view.Columns["NgayTamUng"]));
            //        string str = view.GetRowCellDisplayText(e.RowHandle, view.Columns["NhanVien!"]);
            //        using (var uow = new UnitOfWork())
            //        {
            //            Employee nv = uow.FindObject<Employee>(CriteriaOperator.Parse("HoTen like '" + str + "'"));
            //            XPCollection xpc = new XPCollection(xpcTamUngLuong, CriteriaOperator.Parse(
            //                "NgayTamUng like '%" + dt.Month + "%" + dt.Year + "%'"));

            //            if (xpc.Count != 0)
            //            {
            //                view.SetColumnError(view.Columns["NhanVien!"], "Nhân viên đã tạm ứng trong tháng.");
            //            }
            //        }
            //    }
            //    catch
            //    { }
            //}
          
        }


    

    }
    public class MyLocalizer : DevExpress.XtraGrid.Localization.GridLocalizer
    {
        public override string GetLocalizedString(DevExpress.XtraGrid.Localization.GridStringId id)
        {
            if (id == DevExpress.XtraGrid.Localization.GridStringId.ColumnViewExceptionMessage)
                return "Tiền tạm ứng tối thiểu là 500000, tối đa là 1000000";
            return base.GetLocalizedString(id);
        }
    }

}



