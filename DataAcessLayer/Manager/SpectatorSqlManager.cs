using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Manager
{
    public class SpectatorSqlManager : ISpectatorManager
    {
        public List<ISpectator> GetSpectators()
        {
            List<ISpectator> spectators = new List<ISpectator>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Firstname, Lastname, Birthday, Address, Mail"
                    + " FROM Spectator sp, Person pe"
                    + " WHERE sp.PersonId = pe.Id";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ISpectator spectator = new Spectator();
                    spectator.FirstName = sqlDataReader.GetString(0);
                    spectator.LastName = sqlDataReader.GetString(1);
                    spectator.Birthday = sqlDataReader.GetDateTime(2);
                    spectator.Address = sqlDataReader.GetString(3);
                    spectator.Mail = sqlDataReader.GetString(4);

                    spectators.Add(spectator);
                }
            }

            return spectators;
        }

        public ISpectator FindById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Firstname, Lastname, Birthday, Address, Mail"
                    + " FROM Spectator sp, Person pe"
                    + " WHERE sp.PersonId = pe.Id AND sp.Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    ISpectator spectator = new Spectator();
                    spectator.FirstName = sqlDataReader.GetString(0);
                    spectator.LastName = sqlDataReader.GetString(1);
                    spectator.Birthday = sqlDataReader.GetDateTime(2);
                    spectator.Address = sqlDataReader.GetString(3);
                    spectator.Mail = sqlDataReader.GetString(4);

                    return spectator;
                }
            }

            return null;
        }
    }
}
