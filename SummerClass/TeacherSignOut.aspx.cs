using System;
using static Sidekick.Constant.PageName;
using static Sidekick.Types;
using static Sidekick.SessionManager;

namespace SummerClass
{
    public partial class TeacherSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(GetSessionRoleKey(SessionRole.TEACHER));
            Response.Redirect(TeacherPage.TEACHER_SIGN_IN);
        }
    }
}