using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Team : ITeam
    {
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<IPlayer> _players;

        public List<IPlayer> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        public Team()
        {

        }

        public Team(String name, List<IPlayer> players)
        {
            Name = name;
            Players = players;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(Object o)
        {
            Team team = (Team)o;
            return (Name == team.Name);
        }
    }
}
