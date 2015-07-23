namespace LeTien.Reports
{
    partial class reportTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblDiaChi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenReport = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lbl = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNhanVien = new DevExpress.XtraReports.UI.XRLabel();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 302.8201F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblDiaChi.Multiline = true;
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDiaChi.SizeF = new System.Drawing.SizeF(281.25F, 72.39329F);
            this.lblDiaChi.StylePriority.UseFont = false;
            this.lblDiaChi.StylePriority.UseTextAlignment = false;
            this.lblDiaChi.Text = "Công ty cổ phần TiKi - Tiki.vn\r\nTòa nhà Lữ Gia, 70 Lữ Gia, \r\nPhường 15, Quận 11, " +
    "TPHCM, Việt Nam";
            this.lblDiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTenReport
            // 
            this.lblTenReport.BackColor = System.Drawing.Color.Transparent;
            this.lblTenReport.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lblTenReport.BorderWidth = 0F;
            this.lblTenReport.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenReport.ForeColor = System.Drawing.Color.Blue;
            this.lblTenReport.LocationFloat = new DevExpress.Utils.PointFloat(0F, 96.35162F);
            this.lblTenReport.Name = "lblTenReport";
            this.lblTenReport.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenReport.SizeF = new System.Drawing.SizeF(650F, 52.6067F);
            this.lblTenReport.StylePriority.UseBackColor = false;
            this.lblTenReport.StylePriority.UseBorderColor = false;
            this.lblTenReport.StylePriority.UseBorderWidth = false;
            this.lblTenReport.StylePriority.UseFont = false;
            this.lblTenReport.StylePriority.UseForeColor = false;
            this.lblTenReport.StylePriority.UseTextAlignment = false;
            this.lblTenReport.Text = "TÊN BÁO CÁO";
            this.lblTenReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 45.83333F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 97.91666F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrPageInfo1,
            this.lblDiaChi,
            this.lblTenReport});
            this.ReportHeader.HeightF = 148.9583F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.Format = "{0:N\\gà\\y dd T\\hán\\g M Nă\\m yyyy}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(465.6251F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(184.375F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbl,
            this.lblNhanVien});
            this.ReportFooter.HeightF = 141.6667F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.LocationFloat = new DevExpress.Utils.PointFloat(394.7917F, 0F);
            this.lbl.Multiline = true;
            this.lbl.Name = "lbl";
            this.lbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbl.SizeF = new System.Drawing.SizeF(255.2083F, 54.25F);
            this.lbl.StylePriority.UseFont = false;
            this.lbl.StylePriority.UseTextAlignment = false;
            this.lbl.Text = "Người Lập\r\n(Ký, ghi rõ họ tên)";
            this.lbl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.LocationFloat = new DevExpress.Utils.PointFloat(394.7917F, 109.2916F);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNhanVien.SizeF = new System.Drawing.SizeF(255.2084F, 32.37502F);
            this.lblNhanVien.StylePriority.UseFont = false;
            this.lblNhanVien.StylePriority.UseTextAlignment = false;
            this.lblNhanVien.Text = "Nhân Viên";
            this.lblNhanVien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(35F, 72.39329F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(173.9583F, 2.083336F);
            // 
            // reportChiNhanh
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.DataSource = this.xpCollection1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 46, 98);
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel lbl;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        public DevExpress.XtraReports.UI.XRLabel lblTenReport;
        public DevExpress.XtraReports.UI.XRLabel lblDiaChi;
        private DevExpress.Xpo.XPCollection xpCollection1;
        public DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        public DevExpress.XtraReports.UI.XRLabel lblNhanVien;
    }
}
