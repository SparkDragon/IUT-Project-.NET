using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ITeam
    {
        String Name
        {
            get;
            set;
        }

        List<IPlayer> Players
        {
            get;
            set;
        }
    }
}
