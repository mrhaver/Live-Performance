using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    /// <summary>
    /// in deze klasse wordt al het materiaal aangemaakt dat nodig is voor de
    /// missieprofielen en de missies zelf
    /// </summary>
    public class Materiaal
    {
        // Fields / Properties
        private string naam;

        public string Naam
        {
            get { return naam; }
        }

        // Constructor(s)
        public Materiaal(string naam)
        {
            this.naam = naam;
        }

        public override string ToString()
        {
            return "Naam: " + this.naam;
        }
    }
}
