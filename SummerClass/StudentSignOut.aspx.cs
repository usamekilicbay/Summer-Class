using System;
using static Helper.Constant.PageName;
using static Helper.Types;
using static Helper.Session;

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