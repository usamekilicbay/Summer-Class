using System;
using static Sidekick.Types;
using static Sidekick.Constant.Key;
using static System.Web.HttpContext;

namespace Sidekick
{
    public static class SessionManager
    {
        public static SessionRole GetCurrentSessionRole()
        {
            if (IsSessionKeyExist(GetSessionRoleKey(SessionRole.ADMIN)))
                return SessionRole.ADMIN;
            else if (IsSessionKeyExist(GetSessionRoleKey(SessionRole.TEACHER)))
                return SessionRole.TEACHER;
            else if (IsSessionKeyExist(GetSessionRoleKey(SessionRole.STUDENT)))
                return SessionRole.STUDENT;
            else
                return SessionRole.NON;
        }

        public static string GetSessionRoleKey(SessionRole sessionRole)
        {
            return Enum.GetName(typeof(SessionRole), sessionRole);
        }

        public static string GetCurrentSessionRoleKey()
        {
            return Enum.GetName(typeof(SessionRole), GetCurrentSessionRole());
        }

        public static int GetCurrentUserID()
        {
            return IsSessionKeyExist(GetCurrentSessionRoleKey()) ? (GetCurrentSessionID()) : -1;
        }

        public static int GetCurrentSessionID()
        {
            return Convert.ToInt32(Current.Session[GetCurrentSessionRoleKey()]);
        }

        public static bool IsSessionKeyExist(string sessionKey)
        {
            return Current.Session[sessionKey] != null;
        }
    }
}
