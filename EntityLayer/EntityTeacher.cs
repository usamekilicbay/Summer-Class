using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sidekick.Types;

namespace EntityLayer
{
    public class EntityTeacher
    {
        private int _teacherID;
        public int TeacherID { get => _teacherID; set => _teacherID = value; }

        private string _teacherName;
        public string TeacherName { get => _teacherName; set => _teacherName = value; }

        private string _teacherPassword;
        public string TeacherPassword { get => _teacherPassword; set => _teacherPassword = value; }

        private string _teacherPhoto;
        public string TeacherPhoto { get => _teacherPhoto; set => _teacherPhoto = value; }

        private int _teacherBranch;
        public int TeacherBranch { get => _teacherBranch; set => _teacherBranch = value; }

        private RoleStatus _teacherStatus;
        public RoleStatus TeacherStatus { get => _teacherStatus; set => _teacherStatus = value; }
    }
}
