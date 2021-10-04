using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class Constant
    {
        public static class SQLQuery
        {
            public const string INSERT = "Insert";
            public const string INTO = "Into";
            public const string UPDATE = "Update";
            public const string SET = "Set";
            public const string DELETE = "Delete";
            public const string SELECT = "Select";
            public const string FROM = "From";
            public const string WHERE = "Where";
            public const string VALUES = "Values";
        }

        public static class StudentPath
        {
            public const string STUDEND_ID = "StudentID";
            public const string STUDEND_NAME = "StudentName";
            public const string STUDEND_NUMBER = "StudentNumber";
            public const string STUDEND_PASSWORD = "StudentPassword";
            public const string STUDEND_PHOTO = "StudentPhoto";
            public const string STUDEND_BALANCE = "StudentBalance";
            public const string STUDEND_STATUS = "StudentStatus";
        }

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

        public static class FileExtension
        {
            public const string ASPX = ".aspx";
            public const string MP3 = ".mp3";
            public const string MP4 = ".mp4";
            public const string PNG = ".png";
        }
    }
}
