using EntityLayer;
using Sidekick;
using Sidekick.Constant;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Sidekick.Constant.SQLQuery;
using static Sidekick.Constant.TeacherColumn;
using static Sidekick.Types;

namespace DataAccessLayer
{
    #region CRUD

    public partial class TeacherDataAccess
    {
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
            {
                sqlDataReader.Close();
                return null;
            }

            EntityTeacher entityTeacher = GetTeacherEntity(sqlDataReader);

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

        public static List<EntityTeacher> GetTeacherList()
        {
            List<EntityTeacher> entityTeachers = new List<EntityTeacher>();
            SqlCommand sqlCommand = new SqlCommand($"{SELECT_ALL_FROM_TEACHERS}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
                entityTeachers.Add(GetTeacherEntity(sqlDataReader));


            sqlDataReader.Close();

            return entityTeachers;
        }

        public static string GetTeacherBranch(int teacherBranch)
        {
            SqlCommand sqlCommand = new SqlCommand($"{SELECT + ClassColumn.CLASS_NAME} {FROM_CLASSES + INNER_JOIN + Table.TEACHERS + ON} {Table.CLASSES.Trim()}.{ClassColumn.CLASS_ID}={Table.TEACHERS.Trim()}.{TeacherColumn.TEACHER_BRANCH} {WHERE + TeacherColumn.TEACHER_BRANCH} = {teacherBranch}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (!sqlDataReader.Read())
            {
                sqlDataReader.Close();
                return "NULL";
            }

            string className = sqlDataReader[ClassColumn.CLASS_NAME].ToString();

            sqlDataReader.Close();

            return className;
        }

        private static EntityTeacher GetTeacherEntity(SqlDataReader sqlDataReader)
        {
            return new EntityTeacher
            {
                TeacherID = Convert.ToInt32(sqlDataReader[TEACHER_ID].ToString()),
                TeacherName = sqlDataReader[TEACHER_NAME].ToString(),
                TeacherPassword = sqlDataReader[TEACHER_PASSWORD].ToString(),
                TeacherPhoto = sqlDataReader[TEACHER_PHOTO].ToString(),
                TeacherBranch = Convert.ToInt32(sqlDataReader[TEACHER_BRANCH].ToString()),
                TeacherStatus = (RoleStatus)Convert.ToInt32(sqlDataReader[TEACHER_STATUS])
            };
        }
    }

    #endregion

    #region SESSION

    public partial class TeacherDataAccess
    {
        public static int TeacherSignIn(EntityTeacher entityTeacher)
        {
            string teacherNameQuery = $"{TEACHER_NAME} = '{entityTeacher.TeacherName}'";

            SqlCommand sqlCommand = new SqlCommand($"{SELECT} {TEACHER_ID}, {TEACHER_NAME}, {TEACHER_PASSWORD} {FROM_TEACHERS_WHERE} {teacherNameQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (!sqlDataReader.Read())
            {
                sqlDataReader.Close();
                return -1;
            }

            int teacherID = Convert.ToInt32(sqlDataReader[TEACHER_ID]);
            string teacherPassword = sqlDataReader[TEACHER_PASSWORD].ToString();

            sqlDataReader.Close();

            return string.Equals(entityTeacher.TeacherPassword, teacherPassword) ? teacherID : -1;
        }
    }

    #endregion
}