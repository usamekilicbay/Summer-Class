using BusinessLogicLayer;
using EntityLayer;
using System;
using static Sidekick.Types;
using static Sidekick.Constant.PageName;
using static Sidekick.SessionManager;

namespace SummerClass
{
    public partial class TeacherSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_SignIn_Click(object sender, EventArgs e)
        {
            EntityTeacher entityTeacher = new EntityTeacher
            {
                TeacherName = TXTBOX_TeacherName.Text,
                TeacherPassword = TXTBOX_TeacherPassword.Text
            };

            int currentUserID = TeacherBusinessLogic.TeacherSignIn(entityTeacher);

            if (currentUserID < 0)
            {
                Response.Write("Your Credentials are expired or wrong, please check them again");
                return;
            }

            ChangeSessionStatus(SessionRole.TEACHER, SessionOperation.START, currentUserID);
            Response.Redirect(StudentPage.STUDENT_LIST);
        }
    }
}