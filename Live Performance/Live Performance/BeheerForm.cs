using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Performance
{
    /// <summary>
    /// In dit formulier kunnen alle gegevens beheerd worden
    /// Door middel van tab control kan er makkelijk onderscheid worden gemaakt 
    ///     tussen verschillende functionaliteiten
    /// </summary>
    public partial class BeheerForm : Form
    {
        // Fields / Properties
        private Administratie administratie;
        
        // Constructor(s)
        public BeheerForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            VulMissieProfielen();
            VulMissies();
        }

        

        // Event Handlers
        #region EventHandlers
        // als er een ander missieprofiel gekozen wordt dan moet ook de bemanning aangepast worden
        private void lbMissieProfielen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MissieProfiel mp = (MissieProfiel)lbMissieProfielen.SelectedItem as MissieProfiel;
            mp.GeefMissieProfielBemanning();
            lbMissieProfielBemanning.Items.Clear();
            lbMissieProfielBemanning.Items.Add("Aantal Kapiteins: " + mp.AantalKapiteins);
            lbMissieProfielBemanning.Items.Add("Aantal Biologen: " + mp.AantalBiologen);
            lbMissieProfielBemanning.Items.Add("Aantal Politie: " + mp.AantalPolitie);
        }

        #endregion
     

        // Methoden
        #region Methoden
        
        // doe alle missies in een listbox
        private void VulMissies()
        {
            lbMissies.Items.Clear();
            foreach (Missie m in administratie.Missies)
            {
                lbMissies.Items.Add(m);
            }
        }

        private void VulPersonen()
        {
            lbMissies.Items.Clear();
            foreach(Persoon p in administratie.Personen)
            {
                lbMissies.Items.Add(p);
            }
        }


        private void VulMissieProfielen()
        {
            lbMissieProfielen.Items.Clear();
            foreach(MissieProfiel mp in administratie.MissieProfielen)
            {
                lbMissieProfielen.Items.Add(mp);
            }
        }
        #endregion

        
    }
}
