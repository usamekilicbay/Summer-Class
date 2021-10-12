using System;
using static Helper.Constant.PageName;
using static Helper.Types;
using static Helper.Session;

namespace SummerClass
{
    public partial class TeacherSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(GetSessionKey(SessionRole.TEACHER));
            Response.Redirect(TeacherPage.TEACHER_SIGN_IN);
        }
    }
}