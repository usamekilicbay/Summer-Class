using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helper.Types;

namespace EntityLayer
{
    public class EntityStudent
    {
        private int _studentID;
        public int StudentID { get => _studentID; set => _studentID = value; }

        private string _studentName;
        public string StudentName { get => _studentName; set => _studentName = value; }

        private string _studentNumber;
        public string StudentNumber { get => _studentNumber; set => _studentNumber = value; }

        private string _studentPassword;
        public string StudentPassword { get => _studentPassword; set => _studentPassword = value; }

        private string _studentPhoto;
        public string StudentPhoto { get => _studentPhoto; set => _studentPhoto = value; }

        private double _studentBalance;
        public double StudentBalance { get => _studentBalance; set => _studentBalance = value; }

        private RoleStatus _studentStatus;
        public RoleStatus StudentStatus { get => _studentStatus; set => _studentStatus = value; }
    }
}
