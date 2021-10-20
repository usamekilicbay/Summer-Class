using System;
using static Sidekick.SessionManager;
using static Sidekick.Types;

namespace SummerClass
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[ID] != null)
                Response.Write(Session[ID].ToString());

            SessionRole currentSessionRole = GetCurrentSessionRole();

            bool isCurrentSessionRoleNoN = currentSessionRole == SessionRole.NON;
            bool isCurrentSessionRoleStudent = currentSessionRole == SessionRole.STUDENT;
            bool isCurrentSessionRoleTeacher = currentSessionRole == SessionRole.TEACHER;
            bool isCurrentSessionRoleAdmin = currentSessionRole == SessionRole.ADMIN;
            bool isCurrentSessionRoleAdminOrTeacher = isCurrentSessionRoleAdmin || isCurrentSessionRoleTeacher;

            Response.Write(currentSessionRole);

            UL_SignInAndSignUp.Visible = isCurrentSessionRoleNoN;
            UL_SignOut.Visible = !isCurrentSessionRoleNoN;

            LINK_StudentSignOut.Visible = isCurrentSessionRoleStudent;
            LINK_TeacherSignOut.Visible = isCurrentSessionRoleTeacher;
            LINK_AdminSignOut.Visible = isCurrentSessionRoleAdmin;

            LINK_ClassList.Visible = isCurrentSessionRoleAdminOrTeacher;
            LINK_ClassAppeal.Visible = isCurrentSessionRoleStudent;
            LINK_StudentCreate.Visible = isCurrentSessionRoleAdminOrTeacher;
            LINK_StudentList.Visible = isCurrentSessionRoleAdminOrTeacher;
            LINK_StudentUpdate.Visible = isCurrentSessionRoleStudent;
            LINK_TeacherList.Visible = isCurrentSessionRoleAdmin;
            LINK_TeacherCreate.Visible = isCurrentSessionRoleAdmin;

            DD_Class.Visible = !isCurrentSessionRoleNoN;
            DD_Student.Visible = !isCurrentSessionRoleNoN;
            DD_Teacher.Visible = isCurrentSessionRoleAdminOrTeacher;
        }

        //ALERT_Session.Visible = false;

        //if (!isSessionExist)
        //{
        //    //ALERT_Session.Attributes.CssStyle. = "alert alert-info";
        //    ALERT_Session.Visible = true;
        //    ALERT_Session.InnerText = "Successfully";
        //    STRALERT_Session.InnerText = "Logged Out";
        //    Thread.Sleep(2000);
        //}

        //ALERT_Session.Visible = false;
    }
}