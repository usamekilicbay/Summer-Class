using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using Helper;

namespace DataAccessLayer
{
    public class ClassDataAccess
    {
        public static List<EntityClass> GetClassList()
        {
            List<EntityClass> entityClasses = new List<EntityClass>();
            SqlCommand sqlCommand = new SqlCommand($"Select * From TBL_Classes", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                EntityClass entityClass = new EntityClass
                {
                    ClassID = Convert.ToInt32(sqlDataReader["ClassID"].ToString()),
                    ClassName = sqlDataReader["ClassName"].ToString(),
                    ClassRequiredAppeal = Convert.ToInt32(sqlDataReader["ClassRequiredAppeal"]),
                    ClassQuota = Convert.ToInt32(sqlDataReader["ClassQuota"])
                };

                entityClasses.Add(entityClass);
            }

            sqlDataReader.Close();

            return entityClasses;
        }

        public static int CreateAppeal(EntityAppeal entityAppeal)
        {
            SqlCommand sqlCommand = new SqlCommand($"Insert Into TBL_Appeals (StudentID, ClassID) values ('{entityAppeal.StudentID}', '{entityAppeal.ClassID}')", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery();
        }
    }
}
