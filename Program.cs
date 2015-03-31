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
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2013 Light Gray");
           // DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
           // DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
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
    }
}
