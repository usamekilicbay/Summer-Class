using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace SummerClass
{
    public partial class StudentCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_SaveStudent_Click(object sender, EventArgs e)
        {
            EntityStudent entityStudent = new EntityStudent
            {
                StudentName = TXTBOX_StudentName.Text,
                StudentNumber = TXTBOX_StudentNumber.Text,
                StudentPassword = TXTBOX_StudentPassword.Text,
                StudentPhoto = TXTBOX_StudentPhoto.Text,
            };

            StudentBusinessLogic.CreateStudent(entityStudent);
            Response.Redirect("StudentList.aspx");
        }
    }
}