﻿using Helper.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SummerClass
{
    public partial class StudentLogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(StudentColumn.STUDENT_NUMBER);
            Response.Redirect(PageName.STUDENT_SIGN_IN);
        }
    }
}