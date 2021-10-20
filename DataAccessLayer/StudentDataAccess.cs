using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntityLayer;
using Sidekick;
using static Sidekick.Constant.SQLQuery;
using static Sidekick.Constant.StudentColumn;
using static Sidekick.Types;

namespace DataAccessLayer
{
    #region CRUD

    public partial class StudentDataAccess
    {
        public static int CreateStudent(EntityStudent entityStudent)
        {
            SqlCommand sqlCommand = new SqlCommand($"{INSERT_INTO_STUDENTS} ({STUDENT_NAME}, {STUDENT_NUMBER}, {STUDENT_PASSWORD}, {STUDENT_PHOTO}) {VALUES} ('{entityStudent.StudentName}', '{entityStudent.StudentNumber}', '{entityStudent.StudentPassword}', '{entityStudent.StudentPhoto}')", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery();
        }

        public static EntityStudent GetStudent(int studentID)
        {
            SqlCommand sqlCommand = new SqlCommand($"{SELECT_ALL_FROM_STUDENTS + WHERE} {STUDENT_ID}={studentID}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (!sqlDataReader.Read())
                return null;

            EntityStudent entityStudent = GetStudentEntity(sqlDataReader);

            sqlDataReader.Close();

            return entityStudent;
        }

        public static bool UpdateStudent(EntityStudent entityStudent)
        {
            string studentIDQuery = $"{STUDENT_ID} = '{entityStudent.StudentID}'";
            string studentNameQuery = $"{STUDENT_NAME} = '{entityStudent.StudentName}'";
            string studentNumberQuery = $"{STUDENT_NUMBER} = '{entityStudent.StudentNumber}'";
            string studentPasswordQuery = $"{STUDENT_PASSWORD} = '{entityStudent.StudentPassword}'";
            string studentPhotoQuery = $"{STUDENT_PHOTO} = '{entityStudent.StudentPhoto}'";
            string studentBalanceQuery = $"{STUDENT_BALANCE} = '{entityStudent.StudentBalance}'";
            string studentStatusQuery = $"{STUDENT_STATUS} = '{Convert.ToBoolean(entityStudent.StudentStatus)}'";

            SqlCommand sqlCommand = new SqlCommand($"{UPDATE_STUDENTS_SET} {studentNameQuery}, {studentNumberQuery}, {studentPasswordQuery}, {studentPhotoQuery}, {studentBalanceQuery}, {studentStatusQuery} {WHERE} {studentIDQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static bool ChangeStudentStatus(int studentID, RoleStatus studentStatus)
        {
            string studentIDQuery = $"{STUDENT_STATUS} = '{studentID}'";
            string studentStatusQuery = $"{STUDENT_STATUS} = '{Convert.ToBoolean(studentStatus)}'";

            SqlCommand sqlCommand = new SqlCommand($"{UPDATE_STUDENTS_SET} {studentStatusQuery} {WHERE} {studentIDQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static List<EntityStudent> GetStudentList()
        {
            List<EntityStudent> entityStudents = new List<EntityStudent>();
            SqlCommand sqlCommand = new SqlCommand(SELECT_ALL_FROM_STUDENTS, Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
                entityStudents.Add(GetStudentEntity(sqlDataReader));

            sqlDataReader.Close();

            return entityStudents;
        }

        private static EntityStudent GetStudentEntity(SqlDataReader sqlDataReader)
        {
            return new EntityStudent
            {
                StudentID = Convert.ToInt32(sqlDataReader[STUDENT_ID].ToString()),
                StudentName = sqlDataReader[STUDENT_NAME].ToString(),
                StudentNumber = sqlDataReader[STUDENT_NUMBER].ToString(),
                StudentPassword = sqlDataReader[STUDENT_PASSWORD].ToString(),
                StudentPhoto = sqlDataReader[STUDENT_PHOTO].ToString(),
                StudentBalance = Convert.ToDouble(sqlDataReader[STUDENT_BALANCE].ToString()),
                StudentStatus = (RoleStatus)Convert.ToInt32(sqlDataReader[STUDENT_STATUS])
            };
        }
    }

    #endregion

    #region SESSION

    public partial class StudentDataAccess
    {
        public static int StudentSignIn(EntityStudent entityStudent)
        {
            string studentNumberQuery = $"{STUDENT_NUMBER} = '{entityStudent.StudentNumber}'";

            SqlCommand sqlCommand = new SqlCommand($"{SELECT} {STUDENT_ID}, {STUDENT_NUMBER}, {STUDENT_PASSWORD} {FROM_STUDENTS_WHERE} {studentNumberQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (!sqlDataReader.Read())
            {
                sqlDataReader.Close();
                return -1;
            }

            int studentID = Convert.ToInt32(sqlDataReader[STUDENT_ID]);
            string studentPassword = sqlDataReader[STUDENT_PASSWORD].ToString();

            sqlDataReader.Close();

            return string.Equals(entityStudent.StudentPassword, studentPassword) ? studentID : -1;
        }
    }

    #endregion
}
