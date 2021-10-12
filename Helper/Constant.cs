namespace Sidekick
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

            public const string FROM_APPEALS_WHERE = FROM + Table.APPEALS + WHERE;
            public const string FROM_CLASSES_WHERE = FROM + Table.CLASSES + WHERE;
            public const string FROM_STUDENTS_WHERE = FROM + Table.STUDENTS + WHERE;
            public const string FROM_TEACHERS_WHERE = FROM + Table.TEACHERS + WHERE;

            #endregion
        }

        #region KEY

        public static class Key
        {
            public const string CLASS = "Class";
            public const string CLASS_SPACE = "Class ";
            
            public const string STUDENT = "Student";
            public const string STUDENT_SPACE = STUDENT + " ";

            public const string TEACHER = "Teacher";
            public const string TEACHER_SPACE = TEACHER + " ";
         
            public const string BALANCE = "Balance";
            public const string BRANCH = "Branch";
            public const string ID = "ID";
            public const string NAME = "Name";
            public const string NUMBER = "Number";
            public const string PASSWORD = "Password";
            public const string PHOTO = "Photo";
            public const string QUOTA = "ID";
            public const string REQUIRED_APPEAL = "RequiredAppeal";
            public const string STATUS = "Status";
        }

        #endregion

        #region LABEL

        public static class StudentLabel
        {
            public const string STUDENT_ID = Key.STUDENT_SPACE + Key.ID;
            public const string STUDENT_NAME = Key.STUDENT_SPACE + Key.NAME;
            public const string STUDENT_NUMBER = Key.STUDENT_SPACE + Key.NUMBER;
            public const string STUDENT_PASSWORD = Key.STUDENT_SPACE + Key.PASSWORD;
            public const string STUDENT_PHOTO = Key.STUDENT_SPACE + Key.PHOTO;
            public const string STUDENT_BALANCE = Key.STUDENT_SPACE + Key.BALANCE;
            public const string STUDENT_STATUS = Key.STUDENT_SPACE + Key.STATUS;
        }

        public static class ClassLabel
        {
            public const string CLASS_ID = Key.CLASS_SPACE + Key.ID;
            public const string CLASS_NAME = Key.CLASS_SPACE + Key.NAME;
            public const string CLASS_REQUIRED_APPEAL = Key.CLASS_SPACE + Key.REQUIRED_APPEAL;
            public const string CLASS_QUOTA = Key.CLASS_SPACE + Key.QUOTA;
        }

        #endregion

        public static class Table
        {
            public const string TABLE = "TBL_";
            public const string APPEALS = TABLE + "Appeals ";
            public const string CLASSES = TABLE + "Classes ";
            public const string STUDENTS = TABLE + Key.STUDENT + "s ";
            public const string TEACHERS = TABLE + "Teachers ";
        }

        #region DATABSE TABLE COLUMN

        public static class AppealColumn
        {
            public const string APPEAL_ID = "AppealID";
            public const string CLASS_ID = "ClassID";
            public const string STUDENT_ID = Key.STUDENT + "ID";
        }

        public static class ClassColumn
        {
            public const string CLASS_ID = Key.CLASS + Key.ID;
            public const string CLASS_NAME = Key.CLASS + Key.NAME;
            public const string CLASS_REQUIRED_APPEAL = Key.CLASS + Key.REQUIRED_APPEAL;
            public const string CLASS_QUOTA = Key.CLASS + Key.QUOTA;
        }

        public static class StudentColumn
        {
            public const string STUDENT_ID = Key.STUDENT + Key.ID;
            public const string STUDENT_NAME = Key.STUDENT + Key.NAME;
            public const string STUDENT_NUMBER = Key.STUDENT + Key.NUMBER;
            public const string STUDENT_PASSWORD = Key.STUDENT + Key.PASSWORD;
            public const string STUDENT_PHOTO = Key.STUDENT + Key.PHOTO;
            public const string STUDENT_BALANCE = Key.STUDENT + Key.BALANCE;
            public const string STUDENT_STATUS = Key.STUDENT + Key.STATUS;
        }

        public static class TeacherColumn
        {
            public const string TEACHER_ID = Key.TEACHER + Key.ID;
            public const string TEACHER_NAME = Key.TEACHER + Key.NAME;
            public const string TEACHER_PASSWORD = Key.TEACHER + Key.PASSWORD;
            public const string TEACHER_PHOTO = Key.TEACHER + Key.PHOTO;
            public const string TEACHER_BRANCH = Key.TEACHER + Key.BRANCH;
            public const string TEACHER_STATUS = Key.TEACHER + Key.STATUS;
        }

        #endregion

        public static class PageName
        {
            private const string APPEAL = "Appeal";
            private const string DELETE = "Delete";
            private const string LIST = "List";
            private const string PACIFY_STATUS = "PacifyStatus";
            private const string SIGN_IN = "SignIn";
            private const string SIGN_OUT = "SignOut";
            private const string SIGN_UP = "SignUp";
            private const string UPDATE = "Update";


            public static class ClassPage
            {
                public const string CLASS_APPEAL = Key.CLASS + APPEAL + FileExtension.ASPX;
                public const string CLASS_DELETE = Key.CLASS + DELETE + FileExtension.ASPX;
                public const string CLASS_LIST = Key.CLASS + LIST + FileExtension.ASPX;
                public const string CLASS_UPDATE = Key.CLASS + UPDATE + FileExtension.ASPX;
            }

            public static class StudentPage
            {
                public const string STUDENT_CREATE = Key.STUDENT + "" + FileExtension.ASPX;
                public const string STUDENT_LIST = Key.STUDENT + LIST + FileExtension.ASPX;
                public const string STUDENT_SIGN_IN = Key.STUDENT + SIGN_IN + FileExtension.ASPX;
                public const string STUDENT_SIGN_OUT = Key.STUDENT + SIGN_OUT + FileExtension.ASPX;
                public const string STUDENT_SIGN_UP = Key.STUDENT + SIGN_UP + FileExtension.ASPX;
                public const string STUDENT_STATUS_PACIFY = Key.STUDENT + PACIFY_STATUS + FileExtension.ASPX;
                public const string STUDENT_UPDATE = Key.STUDENT + UPDATE + FileExtension.ASPX;
            }

            public static class TeacherPage
            {
                public const string TEACHER_CREATE = Key.TEACHER + "" + FileExtension.ASPX;
                public const string TEACHER_SIGN_IN = Key.TEACHER + SIGN_IN + FileExtension.ASPX;
                public const string TEACHER_SIGN_OUT = Key.TEACHER + SIGN_OUT + FileExtension.ASPX;
                public const string TEACHER_SIGN_UP = Key.TEACHER + SIGN_UP + FileExtension.ASPX;
                public const string TEACHER_STATUS_PACIFY = Key.TEACHER + PACIFY_STATUS + FileExtension.ASPX;
                public const string TEACHER_UPDATE = Key.TEACHER + UPDATE + FileExtension.ASPX;
            }
        }

        public static class SessionRoleKey
        {
            public const string STUDENT = Key.STUDENT + "";
            public const string TEACHER = Key.TEACHER + "";
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
