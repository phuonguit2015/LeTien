using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LeTien.Objects;
using LeTien.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.List
{
    public partial class FrmQuanLyNgayNghi : FormBase
    {
        private DateTime _ngayBatDau = new DateTime();
        public FrmQuanLyNgayNghi()
        {
            InitializeComponent();
            btnXoa.Enabled = false;
        }

        protected override void OnDelete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                QuanLyNgayNghi br = uow.FindObject<QuanLyNgayNghi>(CriteriaOperator.Parse("NgayBatDau = ?", _ngayBatDau));
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
            xpcQuanLyNgayNghi.Reload();
        }

        protected override void OnPreview()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách quản lý ngày nghĩ";
            base.OnPreview();
        }

        protected override void OnExportXls()
        {
            this.Printer = gridUCList;
            this.PrintCaption = "Danh sách quản lý ngày nghĩ";
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

            // Create a report. 
            XtraReport report = XtraReport.FromFile(@".\\Reports\\DataReport-QLngaynghi.repx", true);
            report.DataSource = xpcQuanLyNgayNghi;

            //OnPreview();
            ReportPrintTool pt = new ReportPrintTool(report);
            pt.AutoShowParametersPanel = true;
            pt.ShowPreviewDialog();
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
            if (grvUCList.GetRowCellDisplayText(e.RowHandle, "NgayBatDau") == string.Empty) return;
            _ngayBatDau = DateTime.Parse(grvUCList.GetRowCellDisplayText(e.RowHandle, "NgayBatDau"));
            btnXoa.Enabled = true;
        }

       


        private void BindingDataCombobox()
        {
            foreach(DanhMucMauNgayNghiLe d in xpcDanhMucMauNgayNghiLe)
            {
                cbbLoaiNgayNghi.Items.Add(d.TenNgayNghi);
            }
        }

        private void FrmQuanLyNgayNghi_Load(object sender, EventArgs e)
        {
            //BindingDataCombobox();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Create a report. 
            XtraReport report = XtraReport.FromFile(@".\\Reports\\DataReport-QLngaynghi.repx", true);
                report.DataSource = xpcQuanLyNgayNghi;
            // Open the report in the End-User Designer. 
            ReportDesignTool tool = new ReportDesignTool(report);
            tool.ShowDesignerDialog();
        }
    }
}
