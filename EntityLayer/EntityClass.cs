using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityClass
    {
        private int _classID;
        public int ClassID { get => _classID; set => _classID = value; }

        private string _className;
        public string ClassName { get => _className; set => _className = value; }

        private int _classRequiredAppeal;
        public int ClassRequiredAppeal { get => _classRequiredAppeal; set => _classRequiredAppeal = value; }

        private int _classQuota;
        public int ClassQuota { get => _classQuota; set => _classQuota = value; }
    }
}
