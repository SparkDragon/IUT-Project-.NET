using DataAccessLayer;
using DataAcessLayer.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class PlayerManager
    {
        private static PlayerManager instance;

        private PlayerManager()
        {

        }

        public static PlayerManager GetInstance()
        {
            if (instance == null)
                instance = new PlayerManager();
            return instance;
        }

        public List<IPlayer> GetPlayers ()
        {
            IPlayerManager playerManager = new PlayerSqlManager();
            return playerManager.GetPlayers();
        }
    }
}
