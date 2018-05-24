using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        protected bool isDbConnectionOpen;
        public string ConnectionString { get; private set; }

        public TimeSpan TimeOut { get; protected set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string cannot be null or empty");
            }

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
