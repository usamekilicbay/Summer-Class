using Helper.Constant;
using System;
using static Helper.Constant.PageName;

namespace SummerClass
{
    public partial class TeacherSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(TeacherColumn.TEACHER_NAME);
            Response.Redirect(TeacherPage.TEACHER_SIGN_OUT);
        }
    }
}