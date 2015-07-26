using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LeTien.Screens.Configurations;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
namespace LeTien.Utils
{
    public class Connector
    {
        public static Configuration LoadConfig()
        {
            Assembly currentAssembly = Assembly.GetCallingAssembly();
            return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public static string sConnectionString = /*"Server=127.0.0.1;Port=3306;Database=letien_db;user id=root;charset=utf8 -utf8_unicode_ci;";*/"XpoProvider=MySql;server=127.0.0.1;Uid=root; database=letien_db;persist security info=true; Charset=utf8_unicode_ci;";
        public static bool Connect()
        {
            Configuration conf = LoadConfig();
            sConnectionString = conf.ConnectionStrings.ConnectionStrings["Firebird"].ConnectionString;
                
            XpoDefault.ConnectionString = sConnectionString;
            try
            {
                Session s = new Session();
                s.Connect();
                s.Disconnect();

            }
            catch (Exception ex)
            {
                FrmDBServer fDB = new FrmDBServer();
                bool error= true;
                System.Windows.Forms.DialogResult accept = fDB.ShowDialog();
                while (accept == System.Windows.Forms.DialogResult.OK && error)
                {
                    switch (fDB.cboLoaiCSDL.SelectedItem as string)
                    {
                        case "MySql":
                            sConnectionString = String.Format("XpoProvider={0};server={1};user id={2};  database={3}; password={4}; persist security info=true;CharSet=utf8;",
                                fDB.cboLoaiCSDL.SelectedItem.ToString(), fDB.txtMayChuCSDL.Text, fDB.txtTaiKhoanCSDL.Text, 
                                fDB.txtTenCSDL.Text,fDB.txtMatKhauCSDL.Text);
                            break;
                        case "MSSqlServer":
                            sConnectionString = String.Format("XpoProvider={0};Data Source={1};User ID={2};Password={4};Initial Catalog={3};Persist Security Info=true",
                                fDB.cboLoaiCSDL.SelectedItem.ToString(), fDB.txtMayChuCSDL.Text, fDB.txtTaiKhoanCSDL.Text,
                                fDB.txtTenCSDL.Text, fDB.txtMatKhauCSDL.Text);
                            break;
                        case "SQLite":
                            sConnectionString = String.Format("XpoProvider={0};Data Source={3}",
                                fDB.cboLoaiCSDL.SelectedItem.ToString(), fDB.txtMayChuCSDL.Text, fDB.txtTaiKhoanCSDL.Text,
                                fDB.txtTenCSDL.Text, fDB.txtMatKhauCSDL.Text);
                            break;
                        case "XmlDataSet":
                            sConnectionString = String.Format("XpoProvider={0};Data Source={3};Read Only=false",
                                fDB.cboLoaiCSDL.SelectedItem.ToString(), fDB.txtMayChuCSDL.Text, fDB.txtTaiKhoanCSDL.Text,
                                fDB.txtTenCSDL.Text, fDB.txtMatKhauCSDL.Text);
                            break;
                        case "MSAccess":
                            sConnectionString = String.Format("XpoProvider={0};Provider=Microsoft.Jet.OLEDB.4.0;Data Source={3};User Id={2};Password={4};",
                                fDB.cboLoaiCSDL.SelectedItem.ToString(), fDB.txtMayChuCSDL.Text, fDB.txtTaiKhoanCSDL.Text,
                                fDB.txtTenCSDL.Text, fDB.txtMatKhauCSDL.Text);
                            break;
                        case "Firebird":
                            sConnectionString = String.Format("XpoProvider={0};DataSource=localhost;User=SYSDBA;Password=masterkey;Database={3};ServerType=0;Charset=utf8",
                                fDB.cboLoaiCSDL.SelectedItem.ToString(), fDB.txtMayChuCSDL.Text, fDB.txtTaiKhoanCSDL.Text,
                                Application.StartupPath + "/" + fDB.txtTenCSDL.Text, fDB.txtMatKhauCSDL.Text);
                            break;
                    };
                    XpoDefault.ConnectionString = sConnectionString;
                    try
                    {
                        Session s = new Session();
                        s.Connect();
                        s.Disconnect();
                        error = false;
                        conf.ConnectionStrings.ConnectionStrings["Firebird"].ConnectionString = sConnectionString;
                        conf.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("ConnectionStrings");
                    }
                    catch (Exception e)
                    {
                        XtraMessageBox.Show(String.Format("Không kết nối được {0}",e.Message), "Thông báo");
                        
                        error = true;
                        accept = fDB.ShowDialog();
                    }
                }
                if (error)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
               
            }

            return true;
        }
      
    }
}
