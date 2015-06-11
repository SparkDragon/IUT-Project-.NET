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
    class TeamSqlManager : ITeamManager
    {
        public List<ITeam> GetTeams()
        {
            IPlayerManager playerManager = new PlayerSqlManager();
            List<ITeam> teams = new List<ITeam>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Name, Id"
                    + " FROM Team";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ITeam team = new Team();
                    team.Name = sqlDataReader.GetString(0);
                    int teamId = sqlDataReader.GetInt32(1);
                    team.Players = this.GetTeamPlayers(teamId);
                    teams.Add(team);
                }
            }

            return teams;
        }

        public List<IPlayer> GetTeamPlayers(int teamId)
        {
            PlayerSqlManager playerManager = new PlayerSqlManager();
            List<IPlayer> players = new List<IPlayer>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Id"
                    + " FROM Player"
                    + " WHERE TeamId = '" + teamId + "'";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    IPlayer player = playerManager.FindById(sqlDataReader.GetInt32(0));

                    players.Add(player);
                }
            }

            return players;
        }

        public ITeam FindById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Name, Id"
                    + " FROM Team"
                    + " WHERE Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    ITeam team = new Team();
                    team.Name = sqlDataReader.GetString(0);
                    int teamId = sqlDataReader.GetInt32(1);
                    team.Players = this.GetTeamPlayers(teamId);

                    return team;
                }
            }

            return null;
        }
    }
}
