using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAppeal
    {
        private int _appealID;
        public int AppealID { get => _appealID; set => _appealID = value; }

        private int _studentID;
        public int StudentID { get => _studentID; set => _studentID = value; }

        private int _classID;
        public int ClassID { get => _classID; set => _classID = value; }
    }
}
