using System;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private String _dbCommand;

        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            if (dbConnection != null && !string.IsNullOrWhiteSpace(dbCommand))
            {
                this._dbConnection = dbConnection;
                this._dbCommand = dbCommand;
            }
            else
            {
                string errorMessage;

                if (dbConnection == null)
                    errorMessage = "Database connection cannot be null";
                else
                    errorMessage = "Database command cannont be empty";
                
                throw new ArgumentNullException(errorMessage);
            }
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Executing command {0}", _dbCommand);
            _dbConnection.Close();
        }
    }
}
