using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using static Helper.Constant.SQLQuery;
using static Helper.Constant.TeacherColumn;
using static Helper.Types;

namespace DataAccessLayer
{
    public partial class DataAccessTeacher
    {
        #region CRUD

        public static int CreateTeacher(EntityTeacher entityTeacher)
        {
            SqlCommand sqlCommand = new SqlCommand($"{INSERT_INTO_TEACHERS} ({TEACHER_ID}, {TEACHER_NAME}, {TEACHER_BRANCH}) {VALUES} ('{entityTeacher.TeacherID}', '{entityTeacher.TeacherName}', {entityTeacher.TeacherBranch})", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery();
        }

        public static EntityTeacher GetTeacher(int teacherID)
        {
            SqlCommand sqlCommand = new SqlCommand($"{SELECT_ALL_FROM_TEACHERS + WHERE} {TEACHER_ID}={teacherID}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (!sqlDataReader.Read())
                return null;

            EntityTeacher entityTeacher = new EntityTeacher
            {
                TeacherID = Convert.ToInt32(sqlDataReader[TEACHER_ID]),
                TeacherName = sqlDataReader[TEACHER_NAME].ToString(),
                TeacherBranch = Convert.ToInt32(sqlDataReader[TEACHER_BRANCH])
            };

            sqlDataReader.Close();

            return entityTeacher;
        }

        public static bool UpdateTeacher(EntityTeacher entityTeacher)
        {
            string teacherIDQuery = $"{TEACHER_ID} = '{entityTeacher.TeacherID}'";
            string teacherNameQuery = $"{TEACHER_NAME} = '{entityTeacher.TeacherName}'";
            string teacherBranchQuery = $"{TEACHER_BRANCH} = '{entityTeacher.TeacherBranch}'";

            SqlCommand sqlCommand = new SqlCommand($"{UPDATE_TEACHERS_SET} {teacherNameQuery}, {teacherBranchQuery} {WHERE} {teacherIDQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static bool ChangetTeacherStatus(int teacherID, RoleStatus roleStatus)
        {
            string teacherIDQuery = $"{TEACHER_ID} = '{teacherID}'";
            string teacherStatusQuery = $"{TEACHER_STATUS} = '{Convert.ToBoolean(roleStatus)}'";

            SqlCommand sqlCommand = new SqlCommand($"{UPDATE_TEACHERS_SET} {teacherStatusQuery} {WHERE} {teacherIDQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }

        #endregion

        #region SESSION

        #endregion
    }
}
