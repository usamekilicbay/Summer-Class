﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummerClass
{
    public partial class TeacherSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_SignIn_Click(object sender, EventArgs e)
        {
            //EntityStudent entityStudent = new EntityStudent
            //{
            //    StudentNumber = TXTBOX_StudentNumber.Text,
            //    StudentPassword = TXTBOX_StudentPassword.Text
            //};

            //if (!StudentBusinessLogic.StudentLogin(entityStudent))
            //{
            //    Response.Write("Your Credentials are expired or wrong, please check them again");
            //    return;
            //}

            //Session.Add(SessionRole.STUDENT.ToString(), TXTBOX_StudentNumber.Text);
            //Response.Redirect(PageName.CLASS_LIST);
        }
    }
}