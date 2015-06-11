using DataAccessLayer;
using DataAcessLayer.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class CupManager
    {
        private static CupManager instance;

        private CupManager ()
        {

        }

        public static CupManager GetInstance()
        {
            if (instance == null)
                instance = new CupManager();
            return instance;
        }

        public List<ICup> GetCups ()
        {
            ICupManager cupManager = new CupSqlManager();
            return cupManager.GetCups();
        }
    }
}
