using System;
using BusinessLogicLayer;
using EntityLayer;
using static Sidekick.Constant.PageName;
using static Sidekick.Types;
using static Sidekick.SessionManager;

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

            int currentUserID = StudentBusinessLogic.StudentSigIn(entityStudent);

            if (currentUserID < 0)
            {
                Response.Write("Your Credentials are expired or wrong, please check them again");
                return;
            }

            Session.Add(GetSessionRoleKey(SessionRole.STUDENT), currentUserID);
            Response.Redirect(ClassPage.CLASS_LIST);
        }
    }
}