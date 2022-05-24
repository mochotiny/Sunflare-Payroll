using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_APP.DB
{
    class DbConnection
    {
        public static string Connect()
        {
            return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("Database.mdf") + ";Integrated Security=True; Connect Timeout=30;");
        }
    }
}
