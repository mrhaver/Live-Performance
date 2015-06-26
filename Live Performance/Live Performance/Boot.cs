using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    public class Boot
    {
        // Fields / Properties
        private string naam;
        private string type;
        private int maxSnelheid;
        private int maxPersonen;
        private Locatie locatie;

        public string Naam
        {
            get { return naam; }
        }

        public string Type
        {
            get { return type; }
        }

        public int MaxSnelheid
        {
            get { return maxSnelheid; }
        }

        public int MaxPersonen
        {
            get { return maxPersonen; }
        }

        public Locatie Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        public Boot(string naam, string type, int maxSnelheid, int maxPersonen)
        {
            this.naam = naam;
            this.type = type;
            this.maxSnelheid = maxSnelheid;
            this.maxPersonen = maxPersonen;
        }

        public override string ToString()
        {
            return "Naam: " + this.naam + ", Type: " + this.type + ", Max Snelheid " + this.maxSnelheid + ", Max Personen " + this.maxPersonen;
        }
    }
}
