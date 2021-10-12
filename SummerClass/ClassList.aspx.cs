using System;
using BusinessLogicLayer;

namespace SummerClass
{
    public partial class ClassList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = ClassBusinessLogic.GetClassList();
            Repeater1.DataBind();
        }
    }
}