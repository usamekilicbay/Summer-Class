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

        #region KEY

        public static class StudentKey
        {
            public const string STUDENT = "Student";
            public const string STUDENT_SPACE = "Student ";

            public const string ID = "ID";
            public const string NAME = "Name";
            public const string NUMBER = "Number";
            public const string PASSWORD = "Password";
            public const string PHOTO = "Photo";
            public const string BALANCE = "Balance";
            public const string STATUS = "Status";
        }

        public static class ClassKey
        {
            public const string CLASS = "Class";
            public const string CLASS_SPACE = "Class ";

            public const string ID = "ID";
            public const string NAME = "Name";
            public const string REQUIRED_APPEAL = "RequiredAppeal";
            public const string QUOTA = "ID";
        }

        #endregion

                #region LABEL

        public static class StudentLabel
        {
            public const string STUDENT_ID = StudentKey.STUDENT_SPACE + StudentKey.ID;
            public const string STUDENT_NAME = StudentKey.STUDENT_SPACE + StudentKey.NAME;
            public const string STUDENT_NUMBER = StudentKey.STUDENT_SPACE + StudentKey.NUMBER;
            public const string STUDENT_PASSWORD = StudentKey.STUDENT_SPACE + StudentKey.PASSWORD;
            public const string STUDENT_PHOTO = StudentKey.STUDENT_SPACE + StudentKey.PHOTO;
            public const string STUDENT_BALANCE = StudentKey.STUDENT_SPACE + StudentKey.BALANCE;
            public const string STUDENT_STATUS = StudentKey.STUDENT_SPACE + StudentKey.STATUS;
        }

        public static class ClassLabel
        {
            public const string CLASS_ID = ClassKey.CLASS_SPACE + ClassKey.ID;
            public const string CLASS_NAME = ClassKey.CLASS_SPACE + ClassKey.NAME;
            public const string CLASS_REQUIRED_APPEAL = ClassKey.CLASS_SPACE + ClassKey.REQUIRED_APPEAL;
            public const string CLASS_QUOTA = ClassKey.CLASS_SPACE + ClassKey.QUOTA;
        }

        #endregion

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
            public const string CLASS_ID = ClassKey.CLASS + ClassKey.ID;
            public const string CLASS_NAME = ClassKey.CLASS + ClassKey.NAME;
            public const string CLASS_REQUIRED_APPEAL = ClassKey.CLASS + ClassKey.REQUIRED_APPEAL;
            public const string CLASS_QUOTA = ClassKey.CLASS + ClassKey.QUOTA;
        }

        public static class StudentColumn
        {
            public const string STUDENT_ID = StudentKey.STUDENT + StudentKey.ID;
            public const string STUDENT_NAME = StudentKey.STUDENT + StudentKey.NAME;
            public const string STUDENT_NUMBER = StudentKey.STUDENT + StudentKey.NUMBER;
            public const string STUDENT_PASSWORD = StudentKey.STUDENT + StudentKey.PASSWORD;
            public const string STUDENT_PHOTO = StudentKey.STUDENT + StudentKey.PHOTO;
            public const string STUDENT_BALANCE = StudentKey.STUDENT + StudentKey.BALANCE;
            public const string STUDENT_STATUS = StudentKey.STUDENT + StudentKey.STATUS;
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

        public static class SessionRoleKey
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
