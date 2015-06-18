using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entity
{
    public class Team : ITeam
    {
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Team()
        {

        }

        public Team(String name)
        {
            Name = name;
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
