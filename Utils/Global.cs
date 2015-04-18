using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeTien.Objects;
namespace LeTien.Utils
{
    static class Global
    {
        private static User _User = null;
        public static User User
        {
            get { return _User;  }
            set { _User = value; }
        }
        public static int SoNgayTrongThang(int m, int y)
        {
            int daysInMonth;

            DateTime now = DateTime.Now;

            if (m == 0 || y == 0)
            {

                daysInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
                m = now.Month;
                y = now.Year;
            }
            else
            {
                daysInMonth = System.DateTime.DaysInMonth(y, m);
            }
            return daysInMonth;
        }
    }
}
