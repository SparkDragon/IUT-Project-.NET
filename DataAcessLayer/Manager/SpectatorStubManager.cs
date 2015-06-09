using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class SpectatorStubManager : ISpectatorManager
    {
        public List<ISpectator> GetSpectators()
        {
            List<ISpectator> spectators = new List<ISpectator>();

            SpectatorFactory spectatorFactory = new SpectatorFactory();

            spectators.Add(spectatorFactory.GetSpectator("Francois", "Hollande", new DateTime(2012, 05, 05), "rue des cons", "flamby@moilepresident.ch"));
            spectators.Add(spectatorFactory.GetSpectator("Benjamin", "Joncoux", new DateTime(1994, 05, 10), "à l'assaut domy", "ben@laden.fr"));
            spectators.Add(spectatorFactory.GetSpectator("Elodie", "Philippe", new DateTime(1993, 04, 16), "chez simon", "elo@dinde.fr"));

            return spectators;
        }
    }
}
