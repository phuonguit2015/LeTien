using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace LeTien.Reports
{
    public partial class reportQuanLyNgayNghi : DevExpress.XtraReports.UI.XtraReport
    {
        public reportQuanLyNgayNghi()
        {
            InitializeComponent();

        }
         public reportQuanLyNgayNghi(XPCollection xpc)
        {
            InitializeComponent();
                    
            this.DataSource = xpc;
        }

    }
}
