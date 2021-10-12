using System;
using static Helper.Types;

namespace SummerClass
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionRole currentSessionRole = Helper.Session.GetCurrentSessionRole();
            Response.Write(currentSessionRole.ToString());
            UL_SignInAndSignUp.Visible = currentSessionRole == SessionRole.NON;
            UL_SignOut.Visible = currentSessionRole != SessionRole.NON;
            //DD_Class.Visible = currentSessionRole != SessionRole.NON;
            //DD_Student.Visible = currentSessionRole != SessionRole.NON;
            LINK_StudentSignOut.Visible = currentSessionRole == SessionRole.STUDENT;
            LINK_TeacherSignOut.Visible = currentSessionRole == SessionRole.TEACHER;

            //switch (SessionControl.GetCurrentSessionRole())
            //{
            //    case SessionRole.NON:
            //        break;
            //    case SessionRole.STUDENT:
            //        break;
            //    case SessionRole.TEACHER:
            //        break;
            //    default:
            //        break;
            //}

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
}