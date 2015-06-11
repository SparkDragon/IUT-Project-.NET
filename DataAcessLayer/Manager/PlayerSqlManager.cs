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
    public class PlayerSqlManager : IPlayerManager
    {
        public List<IPlayer> GetPlayers()
        {
            List<IPlayer> players = new List<IPlayer>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Firstname, Lastname, Birthday, Number, Status, Captain, TeamId"
                    + " FROM Player pl, Person pe"
                    + " WHERE pl.PersonId = pe.Id";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    IPlayer player = new Player();
                    player.FirstName = sqlDataReader.GetString(0);
                    player.LastName = sqlDataReader.GetString(1);
                    player.Birthday = sqlDataReader.GetDateTime(2);
                    player.Number = sqlDataReader.GetInt32(3);
                    player.Status = this.GetStatus(sqlDataReader.GetString(4));
                    player.Captain = sqlDataReader.GetBoolean(5);

                    players.Add(player);
                }
            }

            return players;
        }

        public IPlayer FindById (int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Firstname, Lastname, Birthday, Number, Status, Captain, TeamId"
                    + " FROM Player pl, Person pe"
                    + " WHERE pl.PersonId = pe.Id AND pl.Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    IPlayer player = new Player();
                    player.FirstName = sqlDataReader.GetString(0);
                    player.LastName = sqlDataReader.GetString(1);
                    player.Birthday = sqlDataReader.GetDateTime(2);
                    player.Number = sqlDataReader.GetInt32(3);
                    player.Status = this.GetStatus(sqlDataReader.GetString(4));
                    player.Captain = sqlDataReader.GetBoolean(5);

                    return player;
                }
            }

            return null;
        }

        /**
         * Enregistrer des Status dans la bdd sous forme de int fonctionne mais lors de la recherche, cela ne fonctionne plus...
         * Cette fonction permet simplement de convertir une chaine en une variable de type Status (utilité de l'enum ???)
         */
        private Status GetStatus (String status)
        {
            switch (status)
            {
                case "Beater":
                    return Status.Beater;
                case "Catcher":
                    return Status.Catcher;
                case "Tracker":
                    return Status.Tracker;
                case "Goalkeeper":
                    return Status.Goalkeeper;
            }
            return Status.Beater;
        }
    }
}
