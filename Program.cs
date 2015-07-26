using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LeTien.Utils;
using LeTien.Screens;
using DevExpress.XtraEditors;
using System.Drawing;
using LeTien.Screens.User;
namespace LeTien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;

            DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Seven Classic");
           // DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
           // DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
            // kết nối csdl, nếu không được -> cho người dùng cấu hình lại
            bool isConnected = Connector.Connect();
            if (isConnected == false)
            {
                XtraMessageBox.Show("Không thể kết nối cơ sở dữ liệu, vui lòng liên hệ nhà phát triển để được hỗ trợ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DevExpress.Xpo.XpoDefault.Session.UpdateSchema();
                Application.Run(new FrmLogin());
            }            
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            switch(e.Exception.HResult)
            {
                default:
                    XtraMessageBox.Show("Tháng bạn nhập đã tồn tại vui lòng chọn lại!", "Thông Báo");
                    break;
            }
        }
    }
}
