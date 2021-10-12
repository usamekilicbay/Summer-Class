using System.Data;
using System.Data.SqlClient;

namespace Sidekick
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
