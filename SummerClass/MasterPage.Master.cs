using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace SummerClass
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isSessionExist = !String.IsNullOrEmpty((string)Session["StudentNumber"]);
            UL_LoginAndSignUp.Visible = !isSessionExist;
            UL_LogOut.Visible = isSessionExist;

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