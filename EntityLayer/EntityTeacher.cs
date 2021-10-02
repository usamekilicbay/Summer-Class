using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityTeacher
    {
        private int _teacherID;
        public int TeacherID { get => _teacherID; set => _teacherID = value; }

        private string _teacherName;
        public string TeacherName { get => _teacherName; set => _teacherName = value; }

        private string _teacherBranch;
        public string TeacherBranch { get => _teacherBranch; set => _teacherBranch = value; }
    }
}
