using System;
using static Sidekick.Types;
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

        public static void ChangeSessionStatus(SessionRole sessionRole = SessionRole.NON, SessionOperation sessionOperation = SessionOperation.END, int currentUserID = 0)
        {
            switch (sessionOperation)
            {
                case SessionOperation.START:
                    Current.Session.Add(GetSessionRoleKey(sessionRole), currentUserID);
                    UpdateCurrentStatus(sessionRole);
                    break;
                case SessionOperation.END:
                    Current.Session.Remove(GetSessionRoleKey(sessionRole));
                    Current.Session.Add(GetSessionRoleKey(SessionRole.NON), currentUserID);
                    UpdateCurrentStatus(SessionRole.NON);
                    break;
                default:
                    break;
            }

        }

        private static void UpdateCurrentStatus(SessionRole sessionRole)
        {
            IsCurrentSessionRole.NON = sessionRole == SessionRole.NON;
            IsCurrentSessionRole.STUDENT = sessionRole == SessionRole.STUDENT;
            IsCurrentSessionRole.TEACHER = sessionRole == SessionRole.TEACHER;
            IsCurrentSessionRole.ADMIN = sessionRole == SessionRole.ADMIN;
            IsCurrentSessionRole.ADMIN_OR_TEACHER = IsCurrentSessionRole.ADMIN || IsCurrentSessionRole.TEACHER;
        }
    }
}
