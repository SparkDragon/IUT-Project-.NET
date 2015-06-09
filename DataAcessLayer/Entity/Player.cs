using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Player : IPlayer
    {
        private String _firstName;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private String _lastName;

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private Status _status;

        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private bool _captain;

        public bool Captain
        {
            get { return _captain; }
            set { _captain = value; }
        }

        public Player()
        {

        }

        public Player(String firstName, String lastName, DateTime birthday, int number, Status status, bool captain)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Number = number;
            Status = status;
            Captain = captain;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
