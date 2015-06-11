using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer.Manager;

namespace BusinessLayer
{
    public class CupBusiness
    {
        public List<string> GetCups() 
        {
            CupManager cupManager = CupManager.GetInstance();
            List<ICup> cups = cupManager.GetCups();
            List<string> list = new List<string>();
            foreach (ICup cup in cups)
            {
                list.Add(cup.CupYear.ToString());
            }
            return list;
        } 
    }
}
