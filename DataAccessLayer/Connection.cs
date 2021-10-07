using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TFBGIM5\DOKTRIN;Initial Catalog=SummerClass;Integrated Security=True");
    }
}
