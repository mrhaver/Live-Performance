using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    /// <summary>
    /// Via deze klasse worden alle missies aangemaakt dit zijn dus 
    /// SIN missies en HOPE missies
    /// </summary>
    public class Missie
    {
        // Fields / Properies
        private int ID;
        private DateTime startDatumTijdstip;           
        private string beschrijving;
        private string missieVerslag;
        private string missieSoort;

        // voor SIN missies       
        private int aantalPolitie;

        // voor HOPE missies
        private DateTime eindDatumTijdstip;
        private bool goedGekeurd;

        // Constructor(s)
        public Missie(int ID, DateTime startDatumTijdstip, DateTime eindDatumTijdstip, 
            string beschrijving, string missieVerslag, int aantalPolitie, 
            string missieSoort, bool goedGekeurd)
        {
            this.ID = ID;
            this.startDatumTijdstip = startDatumTijdstip;
            this.eindDatumTijdstip = eindDatumTijdstip;
            this.beschrijving = beschrijving;
            this.missieVerslag = missieVerslag;
            this.aantalPolitie = aantalPolitie;
            this.missieSoort = missieSoort;
            this.goedGekeurd = goedGekeurd;
        }

        public override string ToString()
        {
            return "ID: " + this.ID + " ,Startdatum: " + this.startDatumTijdstip + " ,Missiesoort: " + this.missieSoort;
        }
    }
}
