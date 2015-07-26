using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace LeTien.Screens.Salaries
{
    public partial class FrmTinhLuongThang : Form
    {
        public FrmTinhLuongThang()
        {
            InitializeComponent();
        }

        private void FrmTinhLuongThang_Load(object sender, EventArgs e)
        {
            using(FileStream fs  = new FileStream(Application.StartupPath + "/BangLuong.xlsx", FileMode.Open))
            {
                spreadsheetControl1.LoadDocument(fs, DocumentFormat.OpenXml);
            }
        }
    }
}
