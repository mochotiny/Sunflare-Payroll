using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WFA_APP.DB
{
    class Connection
    {
        public SqlConnection con;
        public Connection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CC"].ConnectionString);          
        }
        public static string type;
    }
}
