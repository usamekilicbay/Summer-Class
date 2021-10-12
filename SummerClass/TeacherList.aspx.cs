using System;
using static BusinessLogicLayer.TeacherBusinessLogic;

namespace SummerClass
{
    public partial class TeacherList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = GetTeacherList();
            Repeater1.DataBind();
        }
    }
}