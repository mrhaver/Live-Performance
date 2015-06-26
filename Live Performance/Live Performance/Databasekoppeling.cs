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

        #region Database Lijsten
        public List<Missie> HaalMissiesOp()
        {
            List<Missie> tempMissies = new List<Missie>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM MISSIE";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    DateTime eindDatumTijdstip = DateTime.MinValue;
                    if (!(dataReader["EINDDATUMTIJDSTIP"] is DBNull))
                    {
                        eindDatumTijdstip = Convert.ToDateTime(dataReader["EINDDATUMTIJDSTIP"]);
                    }
                    string missieVerslag = "";
                    if(!(dataReader["MISSIEVERSLAG"] is DBNull))
                    {
                        missieVerslag = Convert.ToString(dataReader["MISSIEVERSLAG"]);
                    }
                    int aantalPolitie = -1;
                    if (!(dataReader["AANTALPOLITIE"] is DBNull))
                    {
                        aantalPolitie = Convert.ToInt32(dataReader["AANTALPOLITIE"]);
                    }
                    bool goedGekeurd = false;
                    if (!(dataReader["GOEDGEKEURD"] is DBNull))
                    {
                        goedGekeurd = ConvertIntToBool(Convert.ToInt32(dataReader["GOEDGEKEURD"]));
                    }
                    tempMissies.Add(new Missie(Convert.ToInt32(dataReader["ID"]), Convert.ToDateTime(dataReader["STARTDATUMTIJDSTIP"]),
                        eindDatumTijdstip, Convert.ToString(dataReader["BESCHRIJVING"]),
                        missieVerslag, aantalPolitie, Convert.ToString(dataReader["MISSIESOORT"]), goedGekeurd));
                }
                return tempMissies;
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Persoon> HaalPersonenOp()
        {
            List<Persoon> tempPersonen = new List<Persoon>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM PERSOON";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    tempPersonen.Add(new Persoon(Convert.ToString(dataReader["NAAM"]), Convert.ToString(dataReader["INLOGNAAM"]),
                        Convert.ToString(dataReader["WACHTWOORD"]), Convert.ToString(dataReader["PERSONEELTYPE"])));
                }
                return tempPersonen;
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

        public List<MissieProfiel> HaalMissieProfielenOp()
        {
            List<MissieProfiel> tempMissieProfiellen = new List<MissieProfiel>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM MISSIEPROFIEL";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    tempMissieProfiellen.Add(new MissieProfiel(Convert.ToString(dataReader["PROFIEL"]), Convert.ToString(dataReader["BOOTTYPE"]), Convert.ToInt32(dataReader["AANTALTECHNICI"])));
                }
                return tempMissieProfiellen;
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

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

        #region Missie Profiel
        /// <summary>
        /// Hier wordt toegewezen hoeveel bemanning er nodig is voor een missieprofiel
        /// </summary>
        public void GeefMissieProfielBemanning(string profiel, out int aantalKapiteins, 
            out int aantalBiologen, out int aantalPolitie)
        {
            aantalKapiteins = 0;
            aantalBiologen = 0;
            aantalPolitie = 0;
            try
            {
                conn.Open();
                string query = "SELECT * FROM MISSIEPROFIEL_PERSOON WHERE MISSIEPROFIEL_ID IN( " +
                "SELECT ID FROM MISSIEPROFIEL WHERE PROFIEL = :profiel)";
                command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("profiel", profiel));
                OracleDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    if(Convert.ToString(dataReader["PERSOONTYPE"]) == "KAPITEIN")
                    {
                        aantalKapiteins = Convert.ToInt32(dataReader["AANTAL"]);
                    }
                    else if (Convert.ToString(dataReader["PERSOONTYPE"]) == "BIOLOOG")
                    {
                        aantalBiologen = Convert.ToInt32(dataReader["AANTAL"]);
                    }
                    else
                    {
                        aantalPolitie = Convert.ToInt32(dataReader["AANTAL"]);
                    }
                }
            }
            catch(Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion


        #region Helper Functies
        private bool ConvertIntToBool(int integer)
        {
            if(integer == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
