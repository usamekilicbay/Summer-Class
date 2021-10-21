using System;
using static Sidekick.SessionManager;
using static Sidekick.Types;

namespace SummerClass
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session[ID] != null)
            //    Response.Write(Session[ID].ToString());

            //Response.Write(currentSessionRole)();

            UL_SignInAndSignUp.Visible = IsCurrentSessionRole.NON;
            UL_SignOut.Visible = !IsCurrentSessionRole.NON;

            LINK_StudentSignOut.Visible = IsCurrentSessionRole.STUDENT;
            LINK_TeacherSignOut.Visible = IsCurrentSessionRole.TEACHER;
            LINK_AdminSignOut.Visible = IsCurrentSessionRole.ADMIN;

            LINK_ClassList.Visible = IsCurrentSessionRole.ADMIN_OR_TEACHER;
            LINK_ClassAppeal.Visible = IsCurrentSessionRole.STUDENT;
            LINK_StudentCreate.Visible = IsCurrentSessionRole.ADMIN_OR_TEACHER;
            LINK_StudentList.Visible = IsCurrentSessionRole.ADMIN_OR_TEACHER;
            LINK_StudentUpdate.Visible = IsCurrentSessionRole.STUDENT;
            LINK_TeacherList.Visible = IsCurrentSessionRole.ADMIN;
            LINK_TeacherCreate.Visible = IsCurrentSessionRole.ADMIN;

            DD_Class.Visible = !IsCurrentSessionRole.NON;
            DD_Student.Visible = !IsCurrentSessionRole.NON;
            DD_Teacher.Visible = IsCurrentSessionRole.ADMIN_OR_TEACHER;
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