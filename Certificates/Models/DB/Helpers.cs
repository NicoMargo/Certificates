
using System.Data.SqlClient;

namespace certificates.Models.DB
{
    public class Helpers
    {
            private const string connectionString =  "Server=localhost;Database=db_certificates; Trusted_Connection=yes;";
            private static SqlConnection Connection;

            public static void Connect()
            {
                try
                {
                    Connection = new SqlConnection(connectionString);
                    Connection.Open();
                }
                catch
                {

                }
            }

            public static void Disconect()
            {
                try
                {
                    try
                    {
                        Connection.Close();
                    }
                    catch
                    {
                        Connection.Close();
                    }
                }
                catch
                {

                }
            }

            public static SqlDataReader CallProcedureReader(string procedureName, Dictionary<string, object> args)
            {
                Connect();
                SqlCommand CommandConnection = Connection.CreateCommand();
                CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;

                CommandConnection.CommandText = procedureName;
                foreach (string arg in args.Keys)
                {
                    CommandConnection.Parameters.AddWithValue("@" + arg, args[arg]);
                }
                return CommandConnection.ExecuteReader();
            }

            public static int CallNonQuery(string procedureName, Dictionary<string, object> args)
            {
                Connect();
                SqlCommand CommandConnection = Connection.CreateCommand();
                CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;

                CommandConnection.CommandText = procedureName;
                foreach (string arg in args.Keys)
                {
                    CommandConnection.Parameters.AddWithValue("@" + arg, args[arg]);
                }
                return CommandConnection.ExecuteNonQuery();
            }

            

        }
    }
