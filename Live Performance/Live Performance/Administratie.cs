using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    public class Administratie
    {
        // Fields
        private static Persoon nuIngelogd;
        private DatabaseKoppeling dbKoppeling;

        // Properties
        public Persoon NuIngelogd
        {
            get { return nuIngelogd; }
            set { nuIngelogd = value; }
        }

        public List<Missie> Missies
        {
            get { return dbKoppeling.HaalMissiesOp(); }
        }

        public List<Persoon> Personen
        {
            get { return dbKoppeling.HaalPersonenOp(); }
        }

        public List<MissieProfiel> MissieProfielen
        {
            get { return dbKoppeling.HaalMissieProfielenOp(); }
        }

        public List<Materiaal> Materiaal
        {
            get { return dbKoppeling.HaalMateriaalOp(); }
        }

        public List<Boot> Boten
        {
            get { return dbKoppeling.HaalBotenOp(); }
        }

        // Constructor(s)
        public Administratie()
        {
            dbKoppeling = new DatabaseKoppeling();
        }

        #region Persoon
        // Inloggen van een persoon
        public bool LogIn(string inlogNaam, string wachtwoord)
        {
            if(!dbKoppeling.LogIn(inlogNaam, wachtwoord))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Geef een persoon terug voor een bepaalde inlognaam
        public Persoon GeefPersoon(string inlogNaam)
        {
            return dbKoppeling.GeefPersoon(inlogNaam);
        }
        #endregion

        #region MissieProfiel
        public void GeefMissieProfielBemanning(string profiel, out int aantalKapiteins, 
            out int aantalBiologen, out int aantalPolitie)
        {
            aantalKapiteins = 0;
            aantalBiologen = 0;
            aantalPolitie = 0;
            dbKoppeling.GeefMissieProfielBemanning(profiel, out aantalKapiteins,
                out aantalBiologen, out aantalPolitie);
        }

        public List<Materiaal> GeefMissieProfielMateriaal(string profiel)
        {
            return dbKoppeling.GeefMissieProfielMateriaal(profiel);
        }

        public void GeefMissieProfielMateriaalAt(string profiel, out int aantalNav, 
            out int aantalVer, out int aantalMeet, out int aantalGereeds)
        {
            aantalNav = 0;
            aantalVer = 0;
            aantalMeet = 0;
            aantalGereeds = 0;
            dbKoppeling.GeefMissieProfielMateriaalAt(profiel, out aantalNav,
                out aantalVer, out aantalMeet, out aantalGereeds);
        }
        #endregion

        #region Boot

        public Boot DitchtsbijzijndeBoot(int xLocatie, int yLocatie)
        {
            Boot dbBoot = null;
            Double kortsteAfstand = 10000;
            Double afstand = 0;
            foreach (Boot b in Boten)
            {
                afstand = Math.Sqrt(((xLocatie - b.Locatie.X) * (xLocatie - b.Locatie.X)) + ((yLocatie - b.Locatie.Y) * (yLocatie - b.Locatie.Y)));
                if(afstand < kortsteAfstand)
                {
                    dbBoot = b;
                    kortsteAfstand = afstand;
                }                
            }
            return dbBoot;
        }
        #endregion
    }
}
