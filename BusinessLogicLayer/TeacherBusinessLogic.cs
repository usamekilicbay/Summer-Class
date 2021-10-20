using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sidekick.Types;

namespace BusinessLogicLayer
{
    #region CRUD

    public partial class TeacherBusinessLogic
    {
        public static int CreateTeacher(EntityTeacher entityTeacher)
        {
            return IsValidTeacher(entityTeacher) ? TeacherDataAccess.CreateTeacher(entityTeacher) : -1;
        }

        public static EntityTeacher GetTeacher(int teacherID)
        {
            return TeacherDataAccess.GetTeacher(teacherID);
        }

        public static bool UpdateTeacher(EntityTeacher entityTeacher)
        {
            return IsValidTeacher(entityTeacher) && TeacherDataAccess.UpdateTeacher(entityTeacher);
        }

        public static bool ChangeTeacherStatus(int teacherID, RoleStatus teacherStatus)
        {
            return TeacherDataAccess.ChangetTeacherStatus(teacherID, teacherStatus);
        }

        public static List<EntityTeacher> GetTeacherList()
        {
            return TeacherDataAccess.GetTeacherList();
        }

        public static string GetTeacherBranch(int teacherBranch)
        {
            return TeacherDataAccess.GetTeacherBranch(teacherBranch);
        }

        public static bool IsValidTeacher(EntityTeacher entityTeacher)
        {
            return !String.IsNullOrEmpty(entityTeacher.TeacherName) && !String.IsNullOrEmpty(entityTeacher.TeacherPassword) && !String.IsNullOrEmpty(entityTeacher.TeacherPhoto);
        }
    }

    #endregion

    #region SESSION

    public partial class TeacherBusinessLogic
    {
        public static int TeacherSignIn(EntityTeacher entityTeacher)
        {
            bool isValidCredential = !String.IsNullOrEmpty(entityTeacher.TeacherName) && !String.IsNullOrEmpty(entityTeacher.TeacherPassword);

            if (!isValidCredential)
                return -1;

            return TeacherDataAccess.TeacherSignIn(entityTeacher);
        }
    }

    #endregion
}
