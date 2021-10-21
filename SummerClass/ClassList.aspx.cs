using Sidekick;
using System;
using static BusinessLogicLayer.ClassBusinessLogic;

namespace SummerClass
{
    public partial class ClassList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SessionManager.IsCurrentSessionRole.ADMIN_OR_TEACHER)
            {
                UL_ClassNavTabs.Visible = false;
                return;
            }

            Repeater1.DataSource = GetClassList();
            Repeater1.DataBind();
        }
    }
}