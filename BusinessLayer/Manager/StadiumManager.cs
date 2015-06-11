using DataAccessLayer;
using DataAcessLayer.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class StadiumManager
    {
        private static StadiumManager instance;

        private StadiumManager()
        {

        }

        public static StadiumManager GetInstance()
        {
            if (instance == null)
                instance = new StadiumManager();
            return instance;
        }

        public List<IStadium> GetStadiums()
        {
            IStadiumManager stadiumManager = new StadiumSqlManager();
            return stadiumManager.GetStadiums();
        }
    }
}
