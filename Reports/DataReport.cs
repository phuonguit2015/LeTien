using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace LeTien.Reports
{
    public partial class DataReport : DevExpress.XtraReports.UI.XtraReport
    {
        public DataReport()
        {
            InitializeComponent();

        }
         public DataReport(XPCollection xpc)
        {
            InitializeComponent();
                    
            this.DataSource = xpc;
        }

    }
}
