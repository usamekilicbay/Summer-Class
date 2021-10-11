using BusinessLogicLayer;
using EntityLayer;
using Helper.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using static Helper.Types;
using static Helper.Constant.PageName;

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

            Session.Add(SessionRole.TEACHER.ToString(), TXTBOX_TeacherName.Text);
            Response.Redirect(ClassPage.CLASS_LIST);
        }
    }
}