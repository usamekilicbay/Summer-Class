using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class StudentBusinessLogic
    {
        public static bool StudentLogin(EntityStudent entityStudent)
        {
            bool isValidCredential = !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword);

            return isValidCredential && StudentDataAccess.StudentLogin(entityStudent);
        }

        public static int StudentAdd(EntityStudent entityStudent)
        {
            bool isValidStudent = !String.IsNullOrEmpty(entityStudent.StudentName) && !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword) && !String.IsNullOrEmpty(entityStudent.StudentPhoto);

            return isValidStudent ? StudentDataAccess.AddStudent(entityStudent) : -1;
        }

        public static EntityStudent GetStudent(int studentID)
        {
            return StudentDataAccess.GetStudent(studentID);
        }

        public static List<EntityStudent> GetStudentList()
        {
            return StudentDataAccess.GetStudentList();
        }

        public static bool StudentDelete(int studentID)
        {
            return StudentDataAccess.DeleteStudent(studentID);
        }

        public static bool StudentUpdate(EntityStudent entityStudent)
        {
            bool isValidStudent = !String.IsNullOrEmpty(entityStudent.StudentName) && !String.IsNullOrEmpty(entityStudent.StudentNumber) && !String.IsNullOrEmpty(entityStudent.StudentPassword) && !String.IsNullOrEmpty(entityStudent.StudentPhoto);

            return isValidStudent && StudentDataAccess.UpdateStudent(entityStudent);
        }
    }
}
