using System;
using static Sidekick.Types;
using static System.Web.HttpContext;

namespace Sidekick
{
    public static class Session
    {
        public static SessionRole GetCurrentSessionRole()
        {
            if (Current.Session[GetSessionKey(SessionRole.ADMIN)] != null)
                return SessionRole.ADMIN;
            else if (Current.Session[GetSessionKey(SessionRole.TEACHER)] != null)
                return SessionRole.TEACHER;
            else if (Current.Session[GetSessionKey(SessionRole.STUDENT)] != null)
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
