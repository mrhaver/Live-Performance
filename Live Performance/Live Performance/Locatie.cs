using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    public class Locatie
    {
        // Fields / Properties
        private string naam;
        private int x;
        private int y;

        public string Naam
        {
            get { return naam; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        // Constructor(s)
        public Locatie(string naam, int x, int y)
        {
            this.naam = naam;
            this.x = x;
            this.y = y;
        }

        // Methoden
    }
}
