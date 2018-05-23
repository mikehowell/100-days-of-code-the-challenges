using System;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public SqlConnection(string connectionString, TimeSpan timeOut) : this(connectionString)
        {
            base.TimeOut = TimeOut;
        }

        public override void Close()
        {
            if (!isDbConnectionOpen)
            {
                Console.WriteLine("No open connection exists to database {0}", ConnectionString);
            }
            else
            {
                Console.WriteLine("Closing connection to SQL database with connection string {0}", ConnectionString);
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
                Console.WriteLine("Opening connection to SQL database with connection string {0}", ConnectionString);
                isDbConnectionOpen = true;
            }
        }
    }
}
