using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
namespace LeTien.Utils
{
    public class Connector
    {
        public static string sConnectionString = /*"Server=127.0.0.1;Port=3306;Database=letien_db;user id=root;charset=utf8 -utf8_unicode_ci;";*/"XpoProvider=MySql;server=127.0.0.1;Uid=root; database=letien_db;persist security info=true; Charset=utf8_unicode_ci;";
        public static bool Connect()
        {
            
            //sConnectionString = "XpoProvider=MySql;server=127.0.0.1;user id=letien_database; password=cXJI1obP3xB; database=letien_database;persist security info=true;CharSet=utf8;";
            sConnectionString = "XpoProvider=MySql;server=127.0.0.1;user id=root;  database=tikidb;persist security info=true;CharSet=utf8;";
            XpoDefault.ConnectionString = sConnectionString;
            try
            {
                Session s = new Session();
                s.Connect();
                s.Disconnect();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }
      
    }
}
