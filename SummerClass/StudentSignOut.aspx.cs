using Helper.Constant;
using System;
using static Helper.Constant.PageName;

namespace SummerClass
{
    public partial class StudentSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(StudentColumn.STUDENT_NUMBER);
            Response.Redirect(StudentPage.STUDENT_SIGN_IN);
        }
    }
}