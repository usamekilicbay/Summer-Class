using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    #region CRUD

    public class ClassBusinessLogic
    {
        public static List<EntityClass> GetClassList()
        {
            return ClassDataAccess.GetClassList();
        }

        public static int CreateAppeal(EntityAppeal entityAppeal)
        {
            return ClassDataAccess.CreateAppeal(entityAppeal);
        }
    }

    #endregion
}
