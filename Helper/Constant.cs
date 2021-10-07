namespace Helper
{
    namespace Constant
    {
        public static class SQLQuery
        {
            public const string INSERT = "Insert ";
            public const string INTO = "Into ";
            public const string UPDATE = "Update ";
            public const string SET = "Set ";
            public const string DELETE = "Delete ";
            public const string SELECT = "Select ";
            public const string FROM = "From ";
            public const string WHERE = "Where ";
            public const string VALUES = "Values ";

            #region INSERT INTO

            public const string INSERT_INTO = INSERT + INTO;
            public const string INSERT_INTO_APPEALS = INSERT_INTO + Table.APPEALS;
            public const string INSERT_INTO_CLASSES = INSERT_INTO + Table.CLASSES;
            public const string INSERT_INTO_STUDENTS = INSERT_INTO + Table.STUDENTS;
            public const string INSERT_INTO_TEACHERS = INSERT_INTO + Table.TEACHERS;

            #endregion

            #region SELECT ALL FROM

            public const string SELECT_ALL_FROM = SELECT + " * " + FROM;
            public const string SELECT_ALL_FROM_APPEALS = SELECT_ALL_FROM + Table.APPEALS;
            public const string SELECT_ALL_FROM_CLASSES = SELECT_ALL_FROM + Table.CLASSES;
            public const string SELECT_ALL_FROM_STUDENTS = SELECT_ALL_FROM + Table.STUDENTS;
            public const string SELECT_ALL_FROM_TEACHERS = SELECT_ALL_FROM + Table.TEACHERS;

            #endregion

            #region UPDATE "TABLE" SET

            public const string UPDATE_APPEALS_SET = UPDATE + Table.APPEALS + SET;
            public const string UPDATE_CLASSES_SET = UPDATE + Table.CLASSES + SET;
            public const string UPDATE_STUDENTS_SET = UPDATE + Table.STUDENTS + SET;
            public const string UPDATE_TEACHERS_SET = UPDATE + Table.TEACHERS + SET;

            #endregion

            #region FROM "TABLE" WHERE

            public const string FROM_APPEALS_WHERE = FROM + Table.APPEALS + SET;
            public const string FROM_CLASSES_WHERE = FROM + Table.CLASSES + SET;
            public const string FROM_STUDENTS_WHERE = FROM + Table.STUDENTS + SET;
            public const string FROM_TEACHERS_WHERE = FROM + Table.TEACHERS + SET;

            #endregion
        }

        public static class Table
        {
            public const string TABLE = "TBL_";
            public const string APPEALS = TABLE + "Appeals ";
            public const string CLASSES = TABLE + "Classes ";
            public const string STUDENTS = TABLE + "Students ";
            public const string TEACHERS = TABLE + "Teachers ";
        }

        #region DATABSE TABLE COLUMN

        public static class AppealColumn
        {
            public const string APPEAL_ID = "AppealID";
            public const string CLASS_ID = "ClassID";
            public const string STUDENT_ID = "StudentID";
        }

        public static class ClassColumn
        {
            public const string CLASS_ID = "ClassID";
            public const string CLASS_NAME = "ClassName";
            public const string CLASS_REQUIRED_APPEAL = "ClassRequiredAppeal";
            public const string CLASS_QUOTA = "ClassQuota";
        }

        public static class StudentColumn
        {
            public const string STUDENT_ID = "StudentID";
            public const string STUDENT_NAME = "StudentName";
            public const string STUDENT_NUMBER = "StudentNumber";
            public const string STUDENT_PASSWORD = "StudentPassword";
            public const string STUDENT_PHOTO = "StudentPhoto";
            public const string STUDENT_BALANCE = "StudentBalance";
            public const string STUDENT_STATUS = "StudentStatus";
        }

        public static class TeacherColumn
        {
            public const string TEACHER_ID = "StudentID";
            public const string TEACHER_NAME = "StudentName";
            public const string TEACHER_BRANCH = "TeacherBranch";
        }

        #endregion

        public static class PageName
        {
            public const string CLASS_APPEAL = "ClassAppeal" + FileExtension.ASPX;
            public const string CLASS_DELETE = "ClassDelete" + FileExtension.ASPX;
            public const string CLASS_LIST = "ClassList" + FileExtension.ASPX;
            public const string CLASS_UPDATE = "ClassUpdate" + FileExtension.ASPX;
            public const string STUDENT_CREATE = "Student" + FileExtension.ASPX;
            public const string STUDENT_LIST = "StudentList" + FileExtension.ASPX;
            public const string STUDENT_SIGN_IN = "StudentSignIn" + FileExtension.ASPX;
            public const string STUDENT_SIGN_OUT = "StudentSignOut" + FileExtension.ASPX;
            public const string STUDENT_SIGN_UP = "StudentSignUp" + FileExtension.ASPX;
            public const string STUDENT_STATUS_PACIFY = "StudentStatusPacify" + FileExtension.ASPX;
            public const string STUDENT_UPDATE = "StudentUpdate" + FileExtension.ASPX;
        }

        public static class SessionKey
        {
            public const string STUDENT = "Student";
            public const string TEACHER = "Teacher";
        }

        public static class FileExtension
        {
            public const string ASPX = ".aspx";
            public const string MP3 = ".mp3";
            public const string MP4 = ".mp4";
            public const string PNG = ".png";
        }
    }
}
