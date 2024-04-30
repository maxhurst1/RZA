using Microsoft.Data.SqlClient;
using RZA.models;
using static RZA.SQL;

namespace RZA
{
    /*
     * The SqlFramework class is to simplify the queries to the database allowing
     * passing parameters to interact with the SQL class simplier
     */
    internal class SqlFramework
    {
        // attempts to read an account with the given email and returns it
        public static User? FindUser(string email, string password)
        {
            // callback to handle the data returned from the sql data reader
            // parses the returned data into a user object
            ReaderCallback<User> callback = (SqlDataReader reader) =>
            {
                return new User
                {
                    Id = reader.GetInt32(0),
                    Forename = reader.GetString(1),
                    Surname = reader.GetString(2),
                    Email = reader.GetString(3),
                    Phonenumber = reader.GetString(4),
                    Country = reader.GetString(5),
                    Address = reader.GetString(6),
                    Gender = reader.GetString(7),
                    Password = reader.GetString(8)
                };
            };

            // attempts to read from the sql accounts table to find one with a matching email
            // will be null if none is found
            User? user = Read("FindAccount",
                new SqlParameter[]
                {
                    new SqlParameter("@email", email),
                    new SqlParameter("@password", password)
                },
            callback);

            return user;
        }

        public static bool EmailExists(string email)
        {
            // callback to handle the data returned from the procedures
            // returns the sql bit returned (true or false)
            ReaderCallback<bool> callback = (SqlDataReader reader) =>
            {
                return reader.GetBoolean(0);
            };

            // checks if the email passed into the method already exists in a record in the accounts table
            bool exists = Read("EmailExists",
                new SqlParameter[]
                {
                    new SqlParameter("@email", email),
                },
            callback);

            return exists;
        }

        /*
         * The following methods will run store procedures to insert data into one of the tables
         * using the passed model
         * This is done to make the code in the forms more readable
         * However the model's data integrity must be validated before it gets to this point
         */

        // uses a user model the insert a row into the accounts table
        public static void WriteUser(User user)
        {
            Execute("CreateAccount", new SqlParameter[] {
                new SqlParameter("@forename", user.Forename),
                new SqlParameter("@surname", user.Surname),
                new SqlParameter("@email", user.Email),
                new SqlParameter("@phonenumber", user.Password),
                new SqlParameter("@country", user.Country),
                new SqlParameter("@address", user.Address),
                new SqlParameter("@gender", user.Gender),
                new SqlParameter("@password", user.Password)
            });
        }

        // uses a ticket model the insert a row into the tickets table

        public static void WriteTicket(Ticket ticket)
        {
            Execute("CreateTicket", new SqlParameter[] {
                new SqlParameter("@date", ticket.Date),
                new SqlParameter("@entry", ticket.Entry),
                new SqlParameter("@exit", ticket.Exit),
                new SqlParameter("@userid", ticket.UserId),
            });
        }

        // uses a booking model the insert a row into the bookings table

        public static void WriteBooking(Booking booking)
        {
            Execute("CreateBooking", new SqlParameter[]
            {
                new SqlParameter("@number", booking.RoomNumber),
                new SqlParameter("@checkin", booking.CheckIn),
                new SqlParameter("@checkout", booking.CheckOut),
                new SqlParameter("@userid", booking.UserId)
            });
        }
    }
}
