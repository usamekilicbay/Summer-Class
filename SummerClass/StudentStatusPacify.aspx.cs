using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;
using static Helper.Types;

namespace SummerClass
{
    public partial class StudentDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(Request.QueryString["StudentID"]);

            StudentBusinessLogic.ChangeStudentStatus(studentID, RoleStatus.PASSIVE);
            Response.Redirect("StudentList.aspx");
        }
    }
}