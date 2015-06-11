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
    public class RefereeSqlManager : IRefereeManager
    {
        public List<IReferee> GetReferees()
        {
            DataTable results = new DataTable();
            List<IReferee> referees = new List<IReferee>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Firstname, Lastname, Birthday, LifeInsurancePolicyNumber"
                    + " FROM Referee re, Person pe"
                    + " WHERE re.PersonId = pe.Id";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    IReferee referee = new Referee();
                    referee.FirstName = sqlDataReader.GetString(0);
                    referee.LastName = sqlDataReader.GetString(1);
                    referee.Birthday = sqlDataReader.GetDateTime(2);
                    referee.LifeInsurancePolicyNumber = sqlDataReader.GetInt32(3);

                    referees.Add(referee);
                }
            }

            return referees;
        }

        public IReferee FindById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Firstname, Lastname, Birthday, LifeInsurancePolicyNumber"
                    + " FROM Referee re, Person pe"
                    + " WHERE re.PersonId = pe.Id AND re.Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    IReferee referee = new Referee();
                    referee.FirstName = sqlDataReader.GetString(0);
                    referee.LastName = sqlDataReader.GetString(1);
                    referee.Birthday = sqlDataReader.GetDateTime(2);
                    referee.LifeInsurancePolicyNumber = sqlDataReader.GetInt32(3);

                    return referee;
                }
            }

            return null;
        }
    }
}
