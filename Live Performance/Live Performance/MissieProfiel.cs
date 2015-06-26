using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    public class MissieProfiel
    {
        // Fields / Properties
        private Administratie administratie;
        string profiel;
        string bootType;
        int aantalTechnici;
        int aantalKapiteins;
        int aantalBiologen;
        int aantalPolitie;

        public string Profiel
        {
            get { return profiel; }
        }

        public string BootType
        {
            get { return bootType; }
        }

        public int AantalTechnici
        {
            get { return aantalTechnici; }
        }

        public int AantalKapiteins
        {
            get { return aantalKapiteins; }
            set { aantalKapiteins = value; }
        }

        public int AantalBiologen
        {
            get { return aantalBiologen; }
            set { aantalBiologen = value; }
        }

        public int AantalPolitie
        {
            get { return aantalPolitie; }
            set { aantalPolitie = value; }
        }

        public MissieProfiel(string profiel, string bootType, int aantalTechnici)
        {
            administratie = new Administratie();
            this.profiel = profiel;
            this.bootType = bootType;
            this.aantalTechnici = aantalTechnici;
        }

        public void GeefMissieProfielBemanning()
        {
            administratie.GeefMissieProfielBemanning(this.profiel, out aantalKapiteins,
                out aantalBiologen, out aantalPolitie);
        }

        public override string ToString()
        {
            return "Profiel: " + this.profiel + ", Boottype: " + this.bootType +
                ", Technici " + aantalTechnici;
        }
    }
}
