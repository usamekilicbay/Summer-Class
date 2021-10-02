using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace SummerClass
{
    public partial class ClassList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DDLIST_Classes.DataSource = ClassDataAccess.GetClassList();
            DDLIST_Classes.DataTextField = "ClassName";
            DDLIST_Classes.DataValueField = "ClassID";
            DDLIST_Classes.DataBind();
        }

        protected void BTN_Appeal_Click(object sender, EventArgs e)
        {
            EntityAppeal entityAppeal = new EntityAppeal
            {
                StudentID = int.Parse(TXTBOX_StudentID.Text),
                ClassID = int.Parse(DDLIST_Classes.SelectedValue.ToString())
            };

            ClassBusinessLogic.CreateAppeal(entityAppeal);
        }
    }
}