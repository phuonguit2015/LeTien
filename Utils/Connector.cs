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
        public static string sConnectionString = "XpoProvider=MySql;server=localhost;user id=root; password=; database=letien;persist security info=true;CharSet=utf8;";
        public static bool Connect()
        { 
            
            //sConnectionString = "XpoProvider=MySql;server=27.0.15.162;user id=letien_database; password=cXJI1obP3xB; database=letien_database;persist security info=true;CharSet=utf8;";
            //sConnectionString = "XpoProvider=MySql;server=localhost;user id=root; password=; database=letien;persist security info=true;CharSet=utf8;";
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
