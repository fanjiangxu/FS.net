using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DAL
{
    public static class ConfigHelper
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString.ToString();
        public static IDbConnection GetConn(string connStr="")
        {
            if (!string.IsNullOrEmpty(connStr))
            {
                ConfigHelper.connStr = connStr;
            }
            return  new SqlConnection(ConfigHelper.connStr);
        }
    }
}
