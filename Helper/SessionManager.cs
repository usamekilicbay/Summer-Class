using System;
using static Sidekick.Types;
using static Sidekick.Constant.Key;
using static System.Web.HttpContext;

namespace Sidekick
{
    public static class SessionManager
    {
        public static class IsCurrentSessionRole
        {
            public static bool NON;
            public static bool STUDENT;
            public static bool TEACHER;
            public static bool ADMIN;
            public static bool ADMIN_OR_TEACHER;
        }

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

        public static void UpdateCurrentStatusRole()
        {
            IsCurrentSessionRole.NON = GetCurrentSessionRole() == SessionRole.NON;
            IsCurrentSessionRole.STUDENT= GetCurrentSessionRole() == SessionRole.TEACHER;
            IsCurrentSessionRole.TEACHER = GetCurrentSessionRole() == SessionRole.TEACHER;
            IsCurrentSessionRole.ADMIN = GetCurrentSessionRole() == SessionRole.ADMIN;
            IsCurrentSessionRole.ADMIN_OR_TEACHER = IsCurrentSessionRole.ADMIN || IsCurrentSessionRole.TEACHER;
        }
    }
}
