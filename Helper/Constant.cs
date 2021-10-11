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

            public const string FROM_APPEALS_WHERE = FROM + Table.APPEALS + WHERE;
            public const string FROM_CLASSES_WHERE = FROM + Table.CLASSES + WHERE;
            public const string FROM_STUDENTS_WHERE = FROM + Table.STUDENTS + WHERE;
            public const string FROM_TEACHERS_WHERE = FROM + Table.TEACHERS + WHERE;

            #endregion
        }

        #region KEY

        public static class ClassKey
        {
            public const string CLASS = "Class";
            public const string CLASS_SPACE = "Class ";

            public const string ID = "ID";
            public const string NAME = "Name";
            public const string REQUIRED_APPEAL = "RequiredAppeal";
            public const string QUOTA = "ID";
        }

        public static class StudentKey
        {
            public const string STUDENT = "Student";
            public const string STUDENT_SPACE = STUDENT + " ";

            public const string ID = "ID";
            public const string NAME = "Name";
            public const string NUMBER = "Number";
            public const string PASSWORD = "Password";
            public const string PHOTO = "Photo";
            public const string BALANCE = "Balance";
            public const string STATUS = "Status";
        }

        public static class TeacherKey
        {
            public const string TEACHER = "Teacher";
            public const string TEACHER_SPACE = TEACHER + " ";

            public const string ID = "ID";
            public const string NAME = "Name";
            public const string PASSWORD = "Password";
            public const string PHOTO = "Photo";
            public const string BRANCH = "Branch";
            public const string STATUS = "Status";
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
            public const string STUDENTS = TABLE + StudentKey.STUDENT + "s ";
            public const string TEACHERS = TABLE + "Teachers ";
        }

        #region DATABSE TABLE COLUMN

        public static class AppealColumn
        {
            public const string APPEAL_ID = "AppealID";
            public const string CLASS_ID = "ClassID";
            public const string STUDENT_ID = StudentKey.STUDENT + "ID";
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
            public const string TEACHER_ID = TeacherKey.TEACHER + TeacherKey.ID;
            public const string TEACHER_NAME = TeacherKey.TEACHER + TeacherKey.NAME;
            public const string TEACHER_PASSWORD = TeacherKey.TEACHER + TeacherKey.PASSWORD;
            public const string TEACHER_PHOTO = TeacherKey.TEACHER + TeacherKey.PHOTO;
            public const string TEACHER_BRANCH = TeacherKey.TEACHER + TeacherKey.BRANCH;
            public const string TEACHER_STATUS = TeacherKey.TEACHER + TeacherKey.STATUS;
        }

        #endregion

        public static class PageName
        {
            private const string APPEAL= "Appeal";
            private const string DELETE= "Delete";
            private const string LIST= "List";
            private const string PACIFY_STATUS = "PacifyStatus";
            private const string SIGN_IN = "SignIn";
            private const string SIGN_OUT = "SignOut";
            private const string SIGN_UP = "SignUp";
            private const string UPDATE = "Update";


            public static class ClassPage
            {
                public const string CLASS_APPEAL = ClassKey.CLASS + APPEAL+ FileExtension.ASPX;
                public const string CLASS_DELETE = ClassKey.CLASS + DELETE + FileExtension.ASPX;
                public const string CLASS_LIST = ClassKey.CLASS + LIST + FileExtension.ASPX;
                public const string CLASS_UPDATE = ClassKey.CLASS + UPDATE + FileExtension.ASPX;
            }

            public static class StudentPage
            {
                public const string STUDENT_CREATE = StudentKey.STUDENT + "" + FileExtension.ASPX;
                public const string STUDENT_LIST = StudentKey.STUDENT + LIST + FileExtension.ASPX;
                public const string STUDENT_SIGN_IN = StudentKey.STUDENT + SIGN_IN + FileExtension.ASPX;
                public const string STUDENT_SIGN_OUT = StudentKey.STUDENT + SIGN_OUT + FileExtension.ASPX;
                public const string STUDENT_SIGN_UP = StudentKey.STUDENT + SIGN_UP + FileExtension.ASPX;
                public const string STUDENT_STATUS_PACIFY = StudentKey.STUDENT + PACIFY_STATUS + FileExtension.ASPX;
                public const string STUDENT_UPDATE = StudentKey.STUDENT + UPDATE + FileExtension.ASPX;
            }

            public static class TeacherPage
            {
                public const string TEACHER_CREATE = TeacherKey.TEACHER + "" + FileExtension.ASPX;
                public const string TEACHER_SIGN_IN = TeacherKey.TEACHER + SIGN_IN + FileExtension.ASPX;
                public const string TEACHER_SIGN_OUT = TeacherKey.TEACHER + SIGN_OUT + FileExtension.ASPX;
                public const string TEACHER_SIGN_UP = TeacherKey.TEACHER + SIGN_UP + FileExtension.ASPX;
                public const string TEACHER_STATUS_PACIFY = TeacherKey.TEACHER + PACIFY_STATUS + FileExtension.ASPX;
                public const string TEACHER_UPDATE = TeacherKey.TEACHER + UPDATE + FileExtension.ASPX;
            }
        }

        public static class SessionRoleKey
        {
            public const string STUDENT = StudentKey.STUDENT + "";
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
