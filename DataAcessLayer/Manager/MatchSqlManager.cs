using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Manager
{
    public class MatchSqlManager : IMatchManager
    {
        public List<IMatch> GetMatches()
        {
            TeamSqlManager teamManager = new TeamSqlManager();
            StadiumSqlManager stadiumManager = new StadiumSqlManager();
            RefereeSqlManager refereeManager = new RefereeSqlManager();
            CupSqlManager cupManager = new CupSqlManager();

            List<IMatch> matches = new List<IMatch>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Team1Id, Team2Id, StadiumId, RefereeId, Team1Score, Team2Score, CupId, MatchDate, Id"
                    + " FROM Match";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    IMatch match = new Match();
                    match.Team1 = teamManager.FindById(sqlDataReader.GetInt32(0));
                    match.Team2 = teamManager.FindById(sqlDataReader.GetInt32(1));
                    match.Stadium = stadiumManager.FindById(sqlDataReader.GetInt32(2));
                    match.Referee = refereeManager.FindById(sqlDataReader.GetInt32(3));
                    match.Cup = cupManager.FindById(sqlDataReader.GetInt32(4));
                    match.Team1Score = sqlDataReader.GetInt32(5);
                    match.Team2Score = sqlDataReader.GetInt32(6);
                    match.MatchDate = sqlDataReader.GetDateTime(7);
                    match.Spectators = GetMatchSpectators(sqlDataReader.GetInt32(8));

                    matches.Add(match);
                }
            }

            return matches;
        }

        public List<ISpectator> GetMatchSpectators (int matchId)
        {
            SpectatorSqlManager spectatorManager = new SpectatorSqlManager();
            List<ISpectator> spectators = new List<ISpectator>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT SpectatorId"
                    + " FROM MatchSpectators"
                    + " WHERE MatchId = " + matchId;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ISpectator spectator = spectatorManager.FindById(sqlDataReader.GetInt32(0));

                    spectators.Add(spectator);
                }
            }

            return spectators;
        }

        public IMatch FindById(int id)
        {
            TeamSqlManager teamManager = new TeamSqlManager();
            StadiumSqlManager stadiumManager = new StadiumSqlManager();
            RefereeSqlManager refereeManager = new RefereeSqlManager();
            CupSqlManager cupManager = new CupSqlManager();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Team1Id, Team2Id, StadiumId, RefereeId, Team1Score, Team2Score, CupId, MatchDate, Id"
                    + " FROM Match"
                    + " WHERE Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    IMatch match = new Match();
                    match.Team1 = teamManager.FindById(sqlDataReader.GetInt32(0));
                    match.Team2 = teamManager.FindById(sqlDataReader.GetInt32(1));
                    match.Stadium = stadiumManager.FindById(sqlDataReader.GetInt32(2));
                    match.Referee = refereeManager.FindById(sqlDataReader.GetInt32(3));
                    match.Cup = cupManager.FindById(sqlDataReader.GetInt32(4));
                    match.Team1Score = sqlDataReader.GetInt32(5);
                    match.Team2Score = sqlDataReader.GetInt32(6);
                    match.MatchDate = sqlDataReader.GetDateTime(7);
                    match.Spectators = GetMatchSpectators(sqlDataReader.GetInt32(8));

                    return match;
                }
            }

            return null;
        }
    }
}
