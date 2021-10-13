using System;
using BusinessLogicLayer;
using EntityLayer;
using static Sidekick.Constant.PageName;
using static Sidekick.Constant.StudentColumn;
using static Sidekick.SessionManager;
using static Sidekick.Types;

namespace SummerClass
{
    public partial class StudentUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int studentID = GetCurrentSessionRole() == SessionRole.STUDENT ? GetCurrentUserID() : Convert.ToInt32(Request.QueryString[STUDENT_ID]);
            TXTBOX_StudentID.Text = studentID.ToString();
            TXTBOX_StudentID.Enabled = false;

            if (Page.IsPostBack)
                return;

            EntityStudent entityStudent = StudentBusinessLogic.GetStudent(studentID);
            TXTBOX_StudentName.Text = entityStudent.StudentName;
            TXTBOX_StudentNumber.Text = entityStudent.StudentNumber;
            TXTBOX_StudentPassword.Text = entityStudent.StudentPassword;
            TXTBOX_StudentPhoto.Text = entityStudent.StudentPhoto;
            TXTBOX_StudentBalance.Text = entityStudent.StudentBalance.ToString();

            Array statuses = Enum.GetNames(typeof(RoleStatus));

            for (int i = 0; i < statuses.Length; i++)
            {
                DDL_StudentStatus.Items.Add(((RoleStatus)i).ToString());
                DDL_StudentStatus.Items[i].Value = i.ToString();
            }

            DDL_StudentStatus.SelectedIndex = (int)entityStudent.StudentStatus;
        }

        protected void BTN_UpdateStudent_Click(object sender, EventArgs e)
        {
            EntityStudent entityStudent = new EntityStudent
            {
                StudentID = Convert.ToInt32(TXTBOX_StudentID.Text),
                StudentName = TXTBOX_StudentName.Text,
                StudentNumber = TXTBOX_StudentNumber.Text,
                StudentPassword = TXTBOX_StudentPassword.Text,
                StudentPhoto = TXTBOX_StudentPhoto.Text,
                StudentBalance = Convert.ToDouble(TXTBOX_StudentBalance.Text),
                StudentStatus = (RoleStatus)Enum.Parse(typeof(RoleStatus), DDL_StudentStatus.SelectedItem.Value)
            };

            StudentBusinessLogic.StudentUpdate(entityStudent);
            Response.Redirect(StudentPage.STUDENT_LIST);
        }
    }
}