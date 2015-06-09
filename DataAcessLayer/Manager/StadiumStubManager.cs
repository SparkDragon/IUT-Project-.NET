using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StadiumStubManager : IStadiumManager
    {
        public List<IStadium> GetStadiums()
        {
            List<IStadium> stadiums = new List<IStadium>();

            StadiumFactory stadiumFactory = new StadiumFactory();

            stadiums.Add(stadiumFactory.GetStadium("Le silence de la mastercard", 50, "Eddi Malou"));
            stadiums.Add(stadiumFactory.GetStadium("Poneyland", 100, "Le royaume des poneys"));

            return stadiums;
        }
    }
}
