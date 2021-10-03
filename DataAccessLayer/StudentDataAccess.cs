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
    public class StudentDataAccess
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

        public static int AddStudent(EntityStudent entityStudent)
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
                StudentID = Convert.ToInt32(sqlDataReader["StudentID"].ToString()),
                StudentName = sqlDataReader["StudentName"].ToString(),
                StudentNumber = sqlDataReader["StudentNumber"].ToString(),
                StudentPassword = sqlDataReader["StudentPassword"].ToString(),
                StudentPhoto = sqlDataReader["StudentPhoto"].ToString(),
                StudentBalance = Convert.ToDouble(sqlDataReader["StudentBalance"].ToString())
            };

            sqlDataReader.Close();

            return entityStudent;
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
                    StudentBalance = Convert.ToDouble(sqlDataReader["StudentBalance"].ToString())
                };

                entityStudents.Add(entityStudent);
            }

            sqlDataReader.Close();

            return entityStudents;
        }

        public static bool DeleteStudent(int studentID)
        {
            SqlCommand sqlCommand = new SqlCommand($"Delete From TBL_Students WHERE StudentID={studentID}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static bool UpdateStudent(EntityStudent entityStudent)
        {
            string studentID = $"StudentID = '{entityStudent.StudentID}'";
            string studentName = $"StudentName = '{entityStudent.StudentName}'";
            string studentNumber = $"StudentNumber = '{entityStudent.StudentNumber}'";
            string studentPassword = $"StudentPassword = '{entityStudent.StudentPassword}'";
            string studentPhoto = $"StudentPhoto = '{entityStudent.StudentPhoto}'";
            string studentBalance = $"StudentBalance = '{entityStudent.StudentBalance}'";

            SqlCommand sqlCommand = new SqlCommand($"Update TBL_Students Set {studentName}, {studentNumber}, {studentPassword}, {studentPhoto}, {studentBalance} Where {studentID}", Connection.sqlConnection);
            ConnectionHelper.OpenConnectionIfNot(sqlCommand);

            return sqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
