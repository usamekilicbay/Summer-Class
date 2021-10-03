using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;

namespace SummerClass
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Login_Click(object sender, EventArgs e)
        {
            EntityStudent entityStudent = new EntityStudent
            {
                StudentNumber = TXTBOX_StudentNumber.Text,
                StudentPassword = TXTBOX_StudentPassword.Text
            };

            bool isCorrectCredentials = StudentBusinessLogic.StudentLogin(entityStudent);

            if (!isCorrectCredentials)
            {
                Response.Write("Your Credentials are expired or wrong, please check them again");
                return;
            }

            Session.Add("StudentNumber", TXTBOX_StudentNumber.Text);
            Response.Redirect("ClassList.aspx");
        }
    }
}