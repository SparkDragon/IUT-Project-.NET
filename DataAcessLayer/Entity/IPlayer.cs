using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public enum Status
    {
        Beater, 
        Catcher, 
        Goalkeeper, 
        Tracker
    }

    public interface IPlayer : IPerson
    {
        int Number
        {
            get;
            set;
        }
        Status Status
        {
            get;
            set;
        }
        bool Captain
        {
            get;
            set;
        }
    }
}
