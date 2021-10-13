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

            bool isSessionRoleNoN = currentSessionRole == SessionRole.NON;
            bool isSessionRoleStudent = currentSessionRole == SessionRole.STUDENT;
            bool isSessionRoleTeacher = currentSessionRole == SessionRole.TEACHER;
            bool isSessionRoleAdmin = currentSessionRole == SessionRole.ADMIN;
            bool isSessionRoleAdminOrTeacher = isSessionRoleAdmin || isSessionRoleTeacher;


            UL_SignInAndSignUp.Visible = isSessionRoleNoN;
            UL_SignOut.Visible = !isSessionRoleNoN;

            LINK_StudentSignOut.Visible = isSessionRoleStudent;
            LINK_TeacherSignOut.Visible = isSessionRoleTeacher;
            LINK_AdminSignOut.Visible = isSessionRoleAdmin;

            LINK_ClassList.Visible = isSessionRoleAdminOrTeacher;
            LINK_ClassAppeal.Visible = isSessionRoleStudent;
            LINK_StudentCreate.Visible = isSessionRoleAdminOrTeacher;
            LINK_StudentList.Visible = isSessionRoleAdminOrTeacher;
            LINK_StudentUpdate.Visible = isSessionRoleStudent;
            LINK_TeacherList.Visible = isSessionRoleAdmin;
            LINK_TeacherCreate.Visible = isSessionRoleAdmin;

            DD_Class.Visible = !isSessionRoleNoN;
            DD_Student.Visible = !isSessionRoleNoN;
            DD_Teacher.Visible = isSessionRoleAdminOrTeacher;
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