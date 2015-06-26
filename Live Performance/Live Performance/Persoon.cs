using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    public class Persoon
    {
        // Properties
        private string naam;
        private string inlogNaam;
        private string wachtwoord;
        private string personeelType;

        public string Naam
        {
            get { return naam; }
        }

        public string InlogNaam
        {
            get { return inlogNaam; }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
        }

        public string PersoneelType
        {
            get { return personeelType; }
        }

        // Constructor(s)
        public Persoon(string naam, string inlogNaam, string wachtwoord, string personeelType)
        {
            this.naam = naam;
            this.inlogNaam = inlogNaam;
            this.wachtwoord = wachtwoord;
            this.personeelType = personeelType;
        }

        public override string ToString()
        {
            return "Naam: " + this.naam + ", PersoneelType: " + this.personeelType;
        }


    }
}
