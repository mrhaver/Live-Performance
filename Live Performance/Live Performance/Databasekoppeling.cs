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

        public List<Materiaal> HaalMateriaalOp()
        {
            List<Materiaal> tempMateriaal = new List<Materiaal>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM MATERIAAL";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    tempMateriaal.Add(new Materiaal(Convert.ToString(dataReader["NAAM"])));
                }
                return tempMateriaal;
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

        // haalt alle boten op
        public List<Boot> HaalBotenOp()
        {
            List<Boot> tempBoten = new List<Boot>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM BOOT b, BOOT_LOCATIE bl, LOCATIE l WHERE b.ID = bl.BOOT_ID AND l.id = bl.LOCATIE_ID";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    Boot boot = new Boot(Convert.ToString(dataReader["NAAM"]), Convert.ToString(dataReader["TYPE"]), 
                        Convert.ToInt32(dataReader["MAXSNELHEID"]), Convert.ToInt32(dataReader["MAXPERSONEN"]));
                    // voeg ook de locatie toe aan de boot
                    boot.Locatie = new Locatie("Niet van Belang", Convert.ToInt32(dataReader["X"]), Convert.ToInt32(dataReader["Y"]));
                    tempBoten.Add(boot);
                }
                return tempBoten;
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

        // geeft het materiaal van een bepaald missieprofiel terug
        public List<Materiaal> GeefMissieProfielMateriaal(string profiel)
        {
            List<Materiaal> tempMateriaal = new List<Materiaal>();
            try
            {
                conn.Open();
                string query = "SELECT *  FROM MISSIEPROFIEL_MATERIAAL mpm, MATERIAAL m, MISSIEPROFIEL mp WHERE m.ID = mpm.MATERIAAL_ID AND mp.ID = mpm.MATERIAAL_ID AND MISSIEPROFIEL_ID IN(  SELECT ID FROM MISSIEPROFIEL WHERE PROFIEL = :profiel)";
                command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("profiel", profiel));
                OracleDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    int aantal = Convert.ToInt32(dataReader["AANTAL"]);
                    while(aantal > 0)
                    {
                        tempMateriaal.Add(new Materiaal(Convert.ToString(dataReader["NAAM"])));
                        aantal--;
                    }                    
                }
                return tempMateriaal;
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

        public void GeefMissieProfielMateriaalAt(string profiel, out int aantalNav, 
            out int aantalVer, out int aantalMeet, out int aantalGereeds)
        {
            aantalNav = 0;
            aantalVer = 0;
            aantalMeet = 0;
            aantalGereeds = 0;
            try
            {
                conn.Open();
                string query = "SELECT *  FROM MISSIEPROFIEL_MATERIAAL mpm, MATERIAAL m, MISSIEPROFIEL mp WHERE m.ID = mpm.MATERIAAL_ID AND mp.ID = mpm.MATERIAAL_ID AND MISSIEPROFIEL_ID IN(  SELECT ID FROM MISSIEPROFIEL WHERE PROFIEL = :profiel)";
                command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("profiel", profiel));
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if(Convert.ToString(dataReader["NAAM"]) == "Navigatiesysteem")
                    {
                        aantalNav = Convert.ToInt32(dataReader["AANTAL"]);
                    }
                    if (Convert.ToString(dataReader["NAAM"]) == "Verrekijker")
                    {
                        aantalVer = Convert.ToInt32(dataReader["AANTAL"]);
                    }
                    if (Convert.ToString(dataReader["NAAM"]) == "Meetapparatuur")
                    {
                        aantalMeet = Convert.ToInt32(dataReader["AANTAL"]);
                    }
                    if (Convert.ToString(dataReader["NAAM"]) == "Gereedschapskist")
                    {
                        aantalGereeds = Convert.ToInt32(dataReader["AANTAL"]);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        
        #endregion

        #region Missie
        // deze methode gaat niet werken omdat de missie nog child records bevat
        public bool VerwijderMissie(Missie missie)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM MISSIE WHERE ID = :missieid";
                command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("missieid", missie.M_ID));
                command.ExecuteNonQuery();
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
