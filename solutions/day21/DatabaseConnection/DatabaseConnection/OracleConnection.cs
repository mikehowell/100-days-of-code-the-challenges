using System;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public OracleConnection(string connectionString, TimeSpan timeOut) : this(connectionString)
        {
            base.TimeOut = timeOut;
        }
        public override void Close()
        {
            if (!isDbConnectionOpen)
            {
                Console.WriteLine("No open connection exists to database {0}", ConnectionString);
            }
            else
            {
                Console.WriteLine("Closing connection to Oracle database with connection string {0}", ConnectionString);
                isDbConnectionOpen = false;
            }
        }

        public override void Open()
        {
            //TODO: implement timer and if time exceeds timeout, throw exception.
            if (isDbConnectionOpen)
            {
                Console.WriteLine("Connection to database with connection string {0} is already open", ConnectionString);
            }
            else
            {
                Console.WriteLine("Opening connection to Oracle database with connection string {0}", ConnectionString);
                isDbConnectionOpen = true;
            }
        }
    }
}
