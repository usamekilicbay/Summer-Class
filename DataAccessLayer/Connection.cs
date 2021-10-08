using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TFBGIM5\DOKTRIN;Initial Catalog=SummerClass;Integrated Security=True");
    }
}
