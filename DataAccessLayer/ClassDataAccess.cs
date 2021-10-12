using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntityLayer;
using Sidekick;
using Sidekick.Constant;
using static Sidekick.Constant.SQLQuery;
using static Sidekick.Constant.Table;

namespace DataAccessLayer
{
    #region CRUD

    public partial class ClassDataAccess
    {
        public static List<EntityClass> GetClassList()
        {
            List<EntityClass> entityClasses = new List<EntityClass>();
            SqlCommand sqlCommand = new SqlCommand(SELECT_ALL_FROM_CLASSES, Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                EntityClass entityClass = new EntityClass
                {
                    ClassID = Convert.ToInt32(sqlDataReader[ClassColumn.CLASS_ID].ToString()),
                    ClassName = sqlDataReader[ClassColumn.CLASS_NAME].ToString(),
                    ClassRequiredAppeal = Convert.ToInt32(sqlDataReader[ClassColumn.CLASS_REQUIRED_APPEAL]),
                    ClassQuota = Convert.ToInt32(sqlDataReader[ClassColumn.CLASS_QUOTA])
                };

                entityClasses.Add(entityClass);
            }

            sqlDataReader.Close();

            return entityClasses;
        }

        public static int CreateAppeal(EntityAppeal entityAppeal)
        {
            SqlCommand sqlCommand = new SqlCommand($"{INSERT_INTO_APPEALS} ({AppealColumn.CLASS_ID}, {AppealColumn.STUDENT_ID}) {VALUES} ('{entityAppeal.ClassID}', '{entityAppeal.StudentID}')", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery();
        }
    }

    #endregion

    public partial class ClassDataAccess
    {

    }
}
