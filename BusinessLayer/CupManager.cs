using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    class CupManager
    {
        public IList<ICup> GetCups() 
        {
            ICupManager cupManager = new CupStubManager();
            List<ICup> cups = cupManager.GetCups();
            return cups;
        } 
    }
}
