using Microsoft.Data.SqlClient;
using System.Data;

namespace RZA
{
    /*
     * The SQL class is used to run queries into the sql database
     */
    internal class SQL
    {
        // delegate to define to callback used to interact with the sql data reader
        public delegate T ReaderCallback<T>(SqlDataReader reader);

        // delegate to interact with the sqlcommand once initalied
        internal delegate void SqlCommandCallback(SqlCommand command);

        // responsible for opening an sql connection, adding sqlcommand parameters and invoking the sqlcommand callback
        private static void Run(string procedure, SqlParameter[] parameters, SqlCommandCallback callback)
        {
            SqlConnection conn = new SqlConnection(ENV.ConnectionString);

            conn.Open(); // creates and opens a connection

            SqlCommand command = new SqlCommand(procedure, conn);

            command.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter param in parameters) // iterate over each parameter passed and adds them to the command
            {
                command.Parameters.Add(param);
            }

            callback.Invoke(command); // invokes the sqlcommand callback to allow other methods to interact with it

            conn.Close(); // closes the connection
        }

        // responsible for calling executenonquery on the sqlcommand
        public static void Execute(string procedure, SqlParameter[] parameters)
        {
            SqlCommandCallback cmdcallback = (SqlCommand command) =>
            {
                command.ExecuteNonQuery(); // executesnonquery in the sqlcommand callback
            };

            Run(procedure, parameters, cmdcallback);
        }

        // responsible for reading from the sql database and returning its results
        public static T Read<T>(string procedure, SqlParameter[] parameters, ReaderCallback<T> callback)
        {
            T data = default; // default value of T for its value to be over written and returned

            SqlCommandCallback cmdcallback = (SqlCommand command) =>
            {
                SqlDataReader reader = command.ExecuteReader(); // starts the reader

                while (reader.Read()) // invokes the callback to retrieve the object to be returned
                {
                    data = callback.Invoke(reader); // overrides the default value
                }

                reader.Close(); // close the reader
            };

            Run(procedure, parameters, cmdcallback);

            return data; // returned the value recived from the callback
        }
    }
}
