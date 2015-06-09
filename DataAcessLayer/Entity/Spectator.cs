using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Spectator : ISpectator
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

        private String _address;

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private String _mail;

        public String Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public Spectator()
        {

        }

        public Spectator(String firstName, String lastName, DateTime birthday, String address, String mail)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Address = address;
            Mail = mail;
        }
    }
}
