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
    public class StadiumSqlManager : IStadiumManager
    {
        public List<IStadium> GetStadiums()
        {
            List<IStadium> stadiums = new List<IStadium>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Address, PlacesNumber, Name"
                    + " FROM Stadium";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    IStadium stadium = new Stadium();
                    stadium.Address = sqlDataReader.GetString(0);
                    stadium.PlacesNumber = sqlDataReader.GetInt32(1);
                    stadium.Name = sqlDataReader.GetString(2);

                    stadiums.Add(stadium);
                }
            }

            return stadiums;
        }

        public IStadium FindById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Address, PlacesNumber, Name"
                    + " FROM Stadium"
                    + " WHERE Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    IStadium stadium = new Stadium();
                    stadium.Address = sqlDataReader.GetString(0);
                    stadium.PlacesNumber = sqlDataReader.GetInt32(1);
                    stadium.Name = sqlDataReader.GetString(2);

                    return stadium;
                }
            }

            return null;
        }
    }
}
