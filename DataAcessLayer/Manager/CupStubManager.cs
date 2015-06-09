using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CupStubManager : ICupManager
    {
        public List<ICup> GetCups()
        {
            List<ICup> cups = new List<ICup>();

            CupFactory cupFactory = new CupFactory();

            cups.Add(cupFactory.GetCup(2015));
            cups.Add(cupFactory.GetCup(2011));
            cups.Add(cupFactory.GetCup(2007));
            cups.Add(cupFactory.GetCup(2003));

            return cups;
        }
    }
}
