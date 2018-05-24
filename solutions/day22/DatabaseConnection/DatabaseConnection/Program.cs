using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dbCommand = "SELECT * FROM [dbo].[Students] WHERE name = 'Bobby Tables'";

                DbConnection sqlDbConnection = new SqlConnection(@"\\myserver\database", new System.TimeSpan(0, 3, 0));
                DbCommand sqlDbcommand = new DbCommand(sqlDbConnection, dbCommand);
                sqlDbcommand.Execute();

                DbConnection oracleDb = new OracleConnection(@"\\oracleServer\oracledb\");
                DbCommand oracleDbCommand = new DbCommand(oracleDb, dbCommand);
                oracleDbCommand.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred\r\n\r\n{0}", e.Message);
            }

        }
    }
}
