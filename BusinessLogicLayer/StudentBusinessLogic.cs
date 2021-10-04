using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
using static Helper.Types;

namespace BusinessLogicLayer
{
    #region CRUD

    public partial class StudentBusinessLogic
    {
        public static int CreateStudent(EntityStudent entityStudent)
        {
            bool isValidStudent = !String.IsNullOrEmpty(entityStudent.StudentName) && !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword) && !String.IsNullOrEmpty(entityStudent.StudentPhoto);

            return isValidStudent ? StudentDataAccess.CreateStudent(entityStudent) : -1;
        }

        public static EntityStudent GetStudent(int studentID)
        {
            return StudentDataAccess.GetStudent(studentID);
        }

        public static bool StudentUpdate(EntityStudent entityStudent)
        {
            bool isValidStudent = !String.IsNullOrEmpty(entityStudent.StudentName) && !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword) && !String.IsNullOrEmpty(entityStudent.StudentPhoto);

            return isValidStudent && StudentDataAccess.UpdateStudent(entityStudent);
        }

        public static bool ChangeStudentStatus(int studentID, StudentStatus studentStatus)
        {
            return StudentDataAccess.ChangeStudentStatus(studentID, studentStatus);
        }

        public static List<EntityStudent> GetStudentList()
        {
            return StudentDataAccess.GetStudentList();
        }
       
    }

    #endregion

    #region SESSION

    public partial class StudentBusinessLogic
    {
        public static bool StudentLogin(EntityStudent entityStudent)
        {
            bool isValidCredential = !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword);

            return isValidCredential && StudentDataAccess.StudentLogin(entityStudent);
        }
    }

    #endregion
}
