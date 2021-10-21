using System;
using BusinessLogicLayer;
using EntityLayer;
using Sidekick;

namespace SummerClass
{
    public partial class StudentCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SessionManager.IsCurrentSessionRole.ADMIN_OR_TEACHER)
                UL_StudentNavTabs.Visible = true;
        }

        protected void BTN_SaveStudent_Click(object sender, EventArgs e)
        {
            EntityStudent entityStudent = new EntityStudent
            {
                StudentName = TXTBOX_StudentName.Text,
                StudentNumber = TXTBOX_StudentNumber.Text,
                StudentPassword = TXTBOX_StudentPassword.Text,
                StudentPhoto = TXTBOX_StudentPhoto.Text,
            };

            StudentBusinessLogic.CreateStudent(entityStudent);
            Response.Redirect("StudentList.aspx");
        }
    }
}