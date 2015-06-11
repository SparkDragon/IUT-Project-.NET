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
    public class CupSqlManager : ICupManager
    {
        public List<ICup> GetCups()
        {
            DataTable results = new DataTable();
            List<ICup> cups = new List<ICup>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT CupYear FROM Cup";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
                while (sqlDataReader.Read())
                {
                    ICup cup = new Cup();
                    cup.CupYear = sqlDataReader.GetInt32(0);
                    cups.Add(cup);
                }
            }
            
            return cups;
        }

        public ICup FindById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT CupYear"
                    + " FROM Cup"
                    + " WHERE Id = " + id;
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    ICup cup = new Cup();
                    cup.CupYear = sqlDataReader.GetInt32(0);

                    return cup;
                }
            }

            return null;
        }
    }
}
