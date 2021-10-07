using System;
using static Helper.Types;

namespace SummerClass
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionRole currentSessionRole = SessionControl.GetCurrentSessionRole();
            UL_SignInAndSignUp.Visible = currentSessionRole == SessionRole.NON;
            UL_SignOut.Visible = currentSessionRole != SessionRole.NON;

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