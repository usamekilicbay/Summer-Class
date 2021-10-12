using System;
using static Helper.Types;
using static System.Web.HttpContext;

namespace Helper
{
    public static class Session
    {
        public static SessionRole GetCurrentSessionRole()
        {
            if (Current.Session[SessionRole.TEACHER.ToString()] != null)
                return SessionRole.TEACHER;
            else if (Current.Session[SessionRole.STUDENT.ToString()] != null)
                return SessionRole.STUDENT;
            else
                return SessionRole.NON;
        }

        public static string GetSessionKey(SessionRole sessionRole)
        {
            return Enum.GetName(typeof(SessionRole), sessionRole);
        }
    }
}
