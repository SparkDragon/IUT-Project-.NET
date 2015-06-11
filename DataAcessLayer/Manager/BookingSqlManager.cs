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
    public class BookingSqlManager : IBookingManager
    {
        public List<IBooking> GetBookings()
        {
            MatchSqlManager matchManager = new MatchSqlManager();
            List<IBooking> bookings = new List<IBooking>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlDataBase.CONNECTION_STRING))
            {
                String request = "SELECT Price, MatchId, PlacesNumber FROM Booking";
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    IBooking booking = new Booking();
                    booking.Price = sqlDataReader.GetInt32(0);
                    int matchId = sqlDataReader.GetInt32(1);
                    booking.Match = matchManager.FindById(matchId);
                    booking.PlacesNumber = sqlDataReader.GetInt32(2);
                    bookings.Add(booking);
                }
            }

            return bookings;
        }
    }
}
