using static System.Web.HttpContext;
using static Helper.Types;

namespace SummerClass
{
    public class SessionControl : System.Web.UI.UserControl
    {
        public static SessionRole GetCurrentSessionRole()
        {
            if (Current.Session[SessionRole.TEACHER.ToString()] != null)
                return SessionRole.TEACHER;
            else if (Current.Session[SessionRole.TEACHER.ToString()] != null)
                return SessionRole.STUDENT;
            else
                return SessionRole.NON;
        }
    }
}