using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class ConnectionHelper
    {
        public static void OpenConnectionIfNot(SqlCommand sqlCommand)
        {
            if (sqlCommand.Connection.State != ConnectionState.Open)
                sqlCommand.Connection.Open();
        }
    }
}
