using Sidekick;
using System;
using static BusinessLogicLayer.StudentBusinessLogic;

namespace SummerClass
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SessionManager.IsCurrentSessionRole.ADMIN_OR_TEACHER)
            {
                UL_StudentNavTabs.Visible = false;
                return;
            }

            Repeater1.DataSource = GetStudentList();
            Repeater1.DataBind();
        }
    }
}