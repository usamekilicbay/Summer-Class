using Helper.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummerClass
{
    public partial class TeacherSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(TeacherColumn.TEACHER_NAME);
            Response.Redirect(PageName.TEACHER_SIGN_OUT);
        }
    }
}