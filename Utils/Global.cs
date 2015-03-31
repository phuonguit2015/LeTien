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
    }
}
