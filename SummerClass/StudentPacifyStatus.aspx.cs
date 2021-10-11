using System;
using BusinessLogicLayer;
using Helper.Constant;
using static Helper.Constant.PageName;
using static Helper.Types;

namespace SummerClass
{
    public partial class StudentPacifyStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(Request.QueryString[StudentColumn.STUDENT_ID]);

            StudentBusinessLogic.ChangeStudentStatus(studentID, RoleStatus.PASSIVE);
            Response.Redirect(StudentPage.STUDENT_LIST);
        }
    }
}