using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{

    class Program
    {
        static void Main(string[] args)
        {
            DbConnection db = new SqlConnection(@"\\myserver\database", new System.TimeSpan(0,3,0));
            db.Open();
            db.Close();

            DbConnection oracleDb = new OracleConnection(@"\\oracleServer\oracledb\");
            oracleDb.Close();
            oracleDb.Open();
        }
    }
}
