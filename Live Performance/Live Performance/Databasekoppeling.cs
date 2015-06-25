using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Live_Performance
{
    public class DatabaseKoppeling
    {
        // Properties
        private OracleConnection conn;
        private OracleCommand command;
        string user = "dbi322401"; //Dit is de gebruikersnaam
        string pw = "WReRzDY7X7"; //Dit is het wachtwoord

        // Constructor(s)
        public DatabaseKoppeling()
        {
            conn = new OracleConnection();
            command = conn.CreateCommand();
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + "//192.168.15.50:1521/fhictora" + ";";
        }

        // Methoden

        // test of de databaseconnectie werkt
        public bool TestConnectie()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
