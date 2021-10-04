using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using Helper;
using static Helper.Types;

namespace DataAccessLayer
{
    #region CRUD

    public partial class StudentDataAccess
    {
        public static int CreateStudent(EntityStudent entityStudent)
        {
            SqlCommand sqlCommand = new SqlCommand($"Insert Into TBL_Students (StudentName,StudentNumber,StudentPassword,StudentPhoto) values ('{entityStudent.StudentName}', '{entityStudent.StudentNumber}', '{entityStudent.StudentPassword}', '{entityStudent.StudentPhoto}')", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery();
        }

        public static EntityStudent GetStudent(int studentID)
        {
            SqlCommand sqlCommand = new SqlCommand($"Select * From TBL_Students where StudentID={studentID}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (!sqlDataReader.Read())
                return null;

            EntityStudent entityStudent = new EntityStudent
            {
                StudentID = Convert.ToInt32(sqlDataReader["StudentID"]),
                StudentName = sqlDataReader["StudentName"].ToString(),
                StudentNumber = (string)sqlDataReader["StudentNumber"],
                StudentPassword = sqlDataReader["StudentPassword"].ToString(),
                StudentPhoto = sqlDataReader["StudentPhoto"].ToString(),
                StudentBalance = Convert.ToDouble(sqlDataReader["StudentBalance"]),
                StudentStatus = (StudentStatus)Convert.ToInt32(Convert.ToBoolean(sqlDataReader["StudentStatus"]))
            };

            sqlDataReader.Close();

            return entityStudent;
        }

        public static bool UpdateStudent(EntityStudent entityStudent)
        {
            string studentIDQuery = $"StudentID = '{entityStudent.StudentID}'";
            string studentNameQuery = $"StudentName = '{entityStudent.StudentName}'";
            string studentNumberQuery = $"StudentNumber = '{entityStudent.StudentNumber}'";
            string studentPasswordQuery = $"StudentPassword = '{entityStudent.StudentPassword}'";
            string studentPhotoQuery = $"StudentPhoto = '{entityStudent.StudentPhoto}'";
            string studentBalanceQuery = $"StudentBalance = '{entityStudent.StudentBalance}'";
            string studentStatusQuery = $"StudentStatus = '{Convert.ToBoolean(entityStudent.StudentStatus)}'";

            SqlCommand sqlCommand = new SqlCommand($"Update TBL_Students Set {studentNameQuery}, {studentNumberQuery}, {studentPasswordQuery}, {studentPhotoQuery}, {studentBalanceQuery}, {studentStatusQuery} Where {studentIDQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static bool ChangeStudentStatus(int studentID, StudentStatus studentStatus)
        {
            string studentIDQuery = $"StudentID='{studentID}'";
            string studentStatusQuery = $"StudentStatus = '{Convert.ToBoolean(studentStatus)}'";

            SqlCommand sqlCommand = new SqlCommand($"Update TBL_Students Set {studentStatusQuery} WHERE {studentIDQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static List<EntityStudent> GetStudentList()
        {
            List<EntityStudent> entityStudents = new List<EntityStudent>();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBL_Students", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                EntityStudent entityStudent = new EntityStudent
                {
                    StudentID = Convert.ToInt32(sqlDataReader["StudentID"].ToString()),
                    StudentName = sqlDataReader["StudentName"].ToString(),
                    StudentNumber = sqlDataReader["StudentNumber"].ToString(),
                    StudentPassword = sqlDataReader["StudentPassword"].ToString(),
                    StudentPhoto = sqlDataReader["StudentPhoto"].ToString(),
                    StudentBalance = Convert.ToDouble(sqlDataReader["StudentBalance"].ToString()),
                    StudentStatus = (StudentStatus)Convert.ToInt32(sqlDataReader["StudentStatus"])
                };

                entityStudents.Add(entityStudent);
            }

            sqlDataReader.Close();

            return entityStudents;
        }
    }

    #endregion

    #region SESSION

    public partial class StudentDataAccess
    {
        public static bool StudentLogin(EntityStudent entityStudent)
        {
            string studentNumberQuery = $"StudentNumber = '{entityStudent.StudentNumber}'";
            SqlCommand sqlCommand = new SqlCommand($"Select StudentNumber, StudentPassword From TBL_Students Where {studentNumberQuery}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (!sqlDataReader.Read())
            {
                sqlDataReader.Close();
                return false;
            }

            string studentNumber = sqlDataReader["StudentNumber"].ToString();
            string studentPasswprd = sqlDataReader["StudentPassword"].ToString();

            if (!String.IsNullOrEmpty(studentNumber) && String.Equals(entityStudent.StudentPassword, studentPasswprd))
            {
                sqlDataReader.Close();
                return true;
            }

            sqlDataReader.Close();
            return false;
        }
    }

    #endregion
}
