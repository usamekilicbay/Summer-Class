using System;
using BusinessLogicLayer;
using EntityLayer;
using static Helper.Constant.PageName;
using static Helper.Types;

namespace SummerClass
{
    public partial class StudentSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_SigIn_Click(object sender, EventArgs e)
        {
            EntityStudent entityStudent = new EntityStudent
            {
                StudentNumber = TXTBOX_StudentNumber.Text,
                StudentPassword = TXTBOX_StudentPassword.Text
            };

            if (!StudentBusinessLogic.StudentLogin(entityStudent))
            {
                Response.Write("Your Credentials are expired or wrong, please check them again");
                return;
            }

            Session.Add(SessionRole.STUDENT.ToString(), TXTBOX_StudentNumber.Text);
            Response.Redirect(ClassPage.CLASS_LIST);
        }
    }
}