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
            DDLIST_ClassIDs.DataSource = ClassBusinessLogic.GetClassList();
            DDLIST_ClassIDs.DataTextField = "ClassName";
            DDLIST_ClassIDs.DataValueField = "ClassID";
            DDLIST_ClassIDs.DataBind();

            DDLIST_StudentIDs.DataSource = StudentBusinessLogic.GetStudentList();
            DDLIST_StudentIDs.DataTextField = "StudentName";
            DDLIST_StudentIDs.DataValueField = "StudentID";
            DDLIST_StudentIDs.DataBind();
        }

        protected void BTN_Appeal_Click(object sender, EventArgs e)
        {
            EntityAppeal entityAppeal = new EntityAppeal
            {
                StudentID = int.Parse(DDLIST_StudentIDs.SelectedValue.ToString()),
                ClassID = int.Parse(DDLIST_ClassIDs.SelectedValue.ToString())
            };

            ClassBusinessLogic.CreateAppeal(entityAppeal);
        }
    }
}