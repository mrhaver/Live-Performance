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
    }
}
