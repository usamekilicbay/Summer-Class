using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helper.Types;

namespace BusinessLogicLayer
{
    #region CRUD

    public partial class BusinessLogicTeacher
    {
        public static int CreateTeacher(EntityTeacher entityTeacher)
        {
            return IsValidTeacher(entityTeacher) ? DataAccessTeacher.CreateTeacher(entityTeacher) : -1;
        }

        public static EntityTeacher GetTeacher(int teacherID)
        {
            return DataAccessTeacher.GetTeacher(teacherID);
        }

        public static bool UpdateTeacher(EntityTeacher entityTeacher)
        {
            return IsValidTeacher(entityTeacher) && DataAccessTeacher.UpdateTeacher(entityTeacher);
        }

        public static bool ChangeTeacherStatus(int teacherID, RoleStatus teacherStatus)
        {
            return DataAccessTeacher.ChangetTeacherStatus(teacherID, teacherStatus);
        }

        public static List<EntityTeacher> GetTeacherList()
        {
            return DataAccessTeacher.GetTeacherList();
        }

        public static bool IsValidTeacher(EntityTeacher entityTeacher)
        {
            return !String.IsNullOrEmpty(entityTeacher.TeacherName) && !String.IsNullOrEmpty(entityTeacher.TeacherPassword) && !String.IsNullOrEmpty(entityTeacher.TeacherPhoto);
        }
    }

    #endregion

    #region SESSION

    public partial class BusinessLogicTeacher
    {
        public static bool TeacherSignIn(EntityTeacher entityTeacher)
        {
            bool isValidCredential = !String.IsNullOrEmpty(entityTeacher.TeacherName) && !String.IsNullOrEmpty(entityTeacher.TeacherPassword);

            return isValidCredential && DataAccessTeacher.TeacherSignIn(entityTeacher);
        }
    }

    #endregion
}
