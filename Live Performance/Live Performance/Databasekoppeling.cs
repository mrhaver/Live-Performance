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

        #region Persoon
        public bool LogIn(string inlogNaam, string wachtwoord)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM PERSOON";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if(Convert.ToString(dataReader["INLOGNAAM"]) == inlogNaam)
                    {
                        if(Convert.ToString(dataReader["WACHTWOORD"]) == wachtwoord)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }                    
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public Persoon GeefPersoon(string inlogNaam)
        {
            Persoon persoon = null;
            try
            {
                conn.Open();
                string query = "SELECT * FROM PERSOON WHERE INLOGNAAM = :inlogNaam";
                command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("inlogNaam", inlogNaam));
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    persoon = new Persoon(Convert.ToString(dataReader["NAAM"]), Convert.ToString(dataReader["INLOGNAAM"]), Convert.ToString(dataReader["WACHTWOORD"]), Convert.ToString(dataReader["PERSONEELTYPE"]));
                }
                return persoon;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion
    }
}
