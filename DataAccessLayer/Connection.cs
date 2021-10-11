using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=MATEBOOK13\USAMEKILICBAY;Initial Catalog=SummerClass;Integrated Security=True");
    }
}
