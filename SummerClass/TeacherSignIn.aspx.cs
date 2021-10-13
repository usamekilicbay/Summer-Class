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

            if (!TeacherBusinessLogic.TeacherSignIn(entityTeacher))
            {
                Response.Write("Your Credentials are expired or wrong, please check them again");
                return;
            }

            Session.Add(GetSessionRoleKey(SessionRole.STUDENT), TXTBOX_TeacherName.Text);
            Response.Redirect(ClassPage.CLASS_LIST);
        }
    }
}