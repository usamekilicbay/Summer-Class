using System;
using System.Collections.Generic;
using DataAccessLayer;
using EntityLayer;
using static Sidekick.Types;

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
            return !string.IsNullOrEmpty(entityStudent.StudentName) && !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword) && !String.IsNullOrEmpty(entityStudent.StudentPhoto);
        }
    }

    #endregion

    #region SESSION

    public partial class StudentBusinessLogic
    {
        public static int StudentSigIn(EntityStudent entityStudent)
        {
            bool isValidCredential = !string.IsNullOrEmpty(entityStudent.StudentNumber) && !string.IsNullOrEmpty(entityStudent.StudentPassword);
           
            if (!isValidCredential)
                return -1;

            return StudentDataAccess.StudentSignIn(entityStudent);
        }
    }

    #endregion
}
