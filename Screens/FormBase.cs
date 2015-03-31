using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Export;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraPrinting;
using LeTien.Utils;

namespace LeTien.Screens
{
    public partial class FormBase : DevExpress.XtraEditors.XtraForm, IModule
    {
        public FormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xem dữ liệu có được chỉnh sửa xóa gì hay không!
        /// </summary>
        protected bool IsChanged
        {
            get { return (UOW.GetObjectsToSave().Count > 0 || UOW.GetObjectsToDelete().Count > 0); }
        }
        protected IMain IMainFrom
        {
            get { return this.MdiParent as IMain; }
        }
        # region IModule, giao tiếp với Main thông qua các hàm này
        public void New()
        {
            OnNew();
        }
        public void Edit()
        {
            OnEdit();
        }
        public void Delete()
        {
            OnDelete();
        }
        public void Saves()
        {
            OnSave();
        }
        public void Preview()
        {
            OnPreview();
        }
        public void Reload()
        {
            OnReload();
        }
        public void ExportXls()
        {
            OnExportXls();
        }
        #endregion


        #region Hàm virtual, Các form kế thừa có thể overright lại
        protected virtual void OnNew()
        {

        }
        protected virtual void OnEdit()
        {

        }
        protected virtual void OnDelete()
        {
            
        }
        protected virtual void OnSave()
        {
            // lưu những thay đổi xuống -> UOW thực hiện
            if (!IsChanged) return;
            try
            {
                UOW.CommitChanges();
                MessageBox.Show("Đã Lưu", "Thông Báo");
            }
            catch (Exception ex)
            {
                UOW.ReloadChangedObjects();
                string mgs;
                if (ex.Message.Contains("duplicate values in the index, primary key"))
                    mgs = "Trùng mã (tên)";
                else
                    mgs = ex.Message;               
            }

        }
        protected virtual void OnReload()
        {
            UOW.ReloadChangedObjects();
        }
       
        protected virtual void OnExportXls()
        {
            if (Printer == null) return;

            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink link = new DevExpress.XtraPrinting.PrintableComponentLink(ps);
            link.Component = Printer;
            link.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(printableComponentLink_CreateReportHeaderArea);

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;

            link.Margins.Bottom = link.Margins.Left = link.Margins.Right = link.Margins.Top = 50;

            link.CreateDocument();
            string fileName = string.Empty;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Exel 2013 (*.xls)|*.xls";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                fileName = save.FileName;

            if (string.IsNullOrEmpty(fileName)) return;
            link.ExportToXls(fileName);
        }

        #region "Print"
        /// <summary>
        /// thường dùng girdControl
        /// </summary>
        protected IPrintable Printer;
        /// <summary>
        /// Tên báo cáo muốn xuất
        /// </summary>
        protected string PrintCaption = string.Empty;
        protected virtual void OnPreview()
        {
            if (Printer == null) return;
            SplashScreenManager.ShowForm(typeof(WaitFormMain));
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink link = new DevExpress.XtraPrinting.PrintableComponentLink(ps);
            link.Component = Printer;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(printableComponentLink_CreateReportHeaderArea);
            link.CreateReportFooterArea += new CreateAreaEventHandler(printableComponentLink_CreateReportFooterArea);



            link.Margins.Bottom = link.Margins.Left = link.Margins.Right = link.Margins.Top = 50;

            link.CreateDocument();
            link.ShowPreview();
            SplashScreenManager.CloseForm();
        }
        // ghi tên doanh nghiệp, địa chỉ doanh nghiệp, tên báo cáo mặc định
        private void printableComponentLink_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            object tmp;
            EasyParam.GetValue("Tên đơn vị", out tmp, ParamCategory.CompanyInfo, "TÊN DOANH NGHIỆP", DataType.String);
            string companyName = tmp.ToString();
            EasyParam.GetValue("Địa chỉ đơn vị", out tmp, ParamCategory.CompanyInfo, "123-ABC", DataType.String);
            string address = tmp.ToString();

            RectangleF rec;
            string s = string.Empty;

            s = string.Format("Đơn vị: {0}", companyName);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Regular);
            rec = new RectangleF(0, 0, 400, 20);
            e.Graph.DrawString(s, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None);
            s = string.Format("Địa chỉ: {0}", address);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Regular);
            rec = new RectangleF(0, 20, 400, 20);
            e.Graph.DrawString(s, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None);

            // ve tieu de

            e.Graph.Font = new Font("Tahoma", 16, FontStyle.Bold);
            rec = new RectangleF(200, 50, 450, 30);
            e.Graph.DrawString(PrintCaption.ToUpper(), Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None);

        }
        private void printableComponentLink_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
        {
            // TODO: sửa lại load từ tham số các thông tin cần thiết

            RectangleF rec;
            string s = string.Empty;

            s = "Người lập biểu";
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Regular);
            rec = new RectangleF(420, 20, 200, 20);
            e.Graph.BackColor = Color.Transparent;
            e.Graph.DrawString(s, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None);

            s = "ABCDEF";
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            rec = new RectangleF(420, 100, 200, 20);
            e.Graph.BackColor = Color.Transparent;
            e.Graph.DrawString(s, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None);
        }
        #endregion
        
        #endregion
    }
}