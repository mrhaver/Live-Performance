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

        #region
        public void GeefMissieProfielBemanning(string profiel, out int aantalKapiteins, 
            out int aantalBiologen, out int aantalPolitie)
        {
            aantalKapiteins = 0;
            aantalBiologen = 0;
            aantalPolitie = 0;
            dbKoppeling.GeefMissieProfielBemanning(profiel, out aantalKapiteins,
                out aantalBiologen, out aantalPolitie);
        }
        #endregion
    }
}
