using System;
using System.Collections.Generic;
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
            return IsStudentValid(entityStudent) ? StudentDataAccess.CreateStudent(entityStudent) : -1;
        }

        public static EntityStudent GetStudent(int studentID)
        {
            return StudentDataAccess.GetStudent(studentID);
        }

        public static bool StudentUpdate(EntityStudent entityStudent)
        {
            return IsStudentValid(entityStudent) && StudentDataAccess.UpdateStudent(entityStudent);
        }

        public static bool ChangeStudentStatus(int studentID, RoleStatus studentStatus)
        {
            return StudentDataAccess.ChangeStudentStatus(studentID, studentStatus);
        }

        public static List<EntityStudent> GetStudentList()
        {
            return StudentDataAccess.GetStudentList();
        }
       
        private static bool IsStudentValid(EntityStudent entityStudent)
        {
            return !String.IsNullOrEmpty(entityStudent.StudentName) && !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword) && !String.IsNullOrEmpty(entityStudent.StudentPhoto);
        }
    }

    #endregion

    #region SESSION

    public partial class StudentBusinessLogic
    {
        public static bool StudentLogin(EntityStudent entityStudent)
        {
            bool isValidCredential = !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword);

            return isValidCredential && StudentDataAccess.StudentSignIn(entityStudent);
        }
    }

    #endregion
}
