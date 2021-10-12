using System;
using static BusinessLogicLayer.ClassBusinessLogic;

namespace SummerClass
{
    public partial class ClassList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = GetClassList();
            Repeater1.DataBind();
        }
    }
}