using System;
using static Sidekick.Constant.PageName;
using static Sidekick.Types;
using static Sidekick.Session;

namespace SummerClass
{
    public partial class StudentSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(GetSessionKey(SessionRole.TEACHER));
            Response.Redirect(StudentPage.STUDENT_SIGN_IN);
        }
    }
}