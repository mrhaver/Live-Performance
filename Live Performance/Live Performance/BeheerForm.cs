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
            dtpStartDatumTijd.Format = DateTimePickerFormat.Time;
            dtpStartDatumTijd.ShowUpDown = true;
            gbHOPE.Enabled = false;
            gbSIN.Enabled = false;
        }

        

        // Event Handlers
        #region EventHandlers
        // als er een ander missieprofiel gekozen wordt dan moet ook de bemanning aangepast worden
        private void lbMissieProfielen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // vul de personen
            MissieProfiel mp = (MissieProfiel)lbMissieProfielen.SelectedItem as MissieProfiel;
            mp.GeefMissieProfielBemanning();
            lbMissieProfielBemanning.Items.Clear();
            lbMissieProfielBemanning.Items.Add("Aantal Kapiteins: " + mp.AantalKapiteins);
            lbMissieProfielBemanning.Items.Add("Aantal Biologen: " + mp.AantalBiologen);
            lbMissieProfielBemanning.Items.Add("Aantal Politie: " + mp.AantalPolitie);

            // vul het benodigde materiaal
            // er is hier nog een andere methode voor die 'code matig' nog iets beter is deze staat in administratie
            // en heet GeefMissieProfielMateriaal() Deze is alleen minder praktisch
            mp.GeefMissieProfielMateriaalAt();
            lbMissieProfielMateriaal.Items.Clear();
            lbMissieProfielMateriaal.Items.Add("Aantal Navigatiesystemen: " + mp.AantalNav);
            lbMissieProfielMateriaal.Items.Add("Aantal Verrekijkers: " + mp.AantalVer);
            lbMissieProfielMateriaal.Items.Add("Aantal Meetapparatuur: " + mp.AantalMeet);
            lbMissieProfielMateriaal.Items.Add("Aantal Gereedschapskisten: " + mp.AantalGereeds);

        }

        private void btnSelecteerMissieProfiel_Click(object sender, EventArgs e)
        {
            if (rbtnSIN.Checked)
            {
                if (lbMissieProfielMateriaal.Items.Count != 0)
                {
                    if (lbMissieProfielBemanning.Items.Count != 0)
                    {
                        lbMissieProfielen.Enabled = false;
                        lbMissieProfielMateriaal.Enabled = false;
                        lbMissieProfielBemanning.Enabled = false;
                        gbHOPE.Enabled = false;
                        gbSIN.Enabled = true;
                        gbMissie.Enabled = false;

                        // hier mogen ook de personen in de listboxen gevuld worden
                        VulPersonen(lbPersonen);
                        VulMateriaal(lbMateriaal);
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer een missieprofiel");
                }

            }
            if (rbtnHOPE.Checked)
            {
                if (lbMissieProfielMateriaal.Items.Count != 0)
                {
                    if (lbMissieProfielBemanning.Items.Count != 0)
                    {
                        lbMissieProfielen.Enabled = false;
                        lbMissieProfielMateriaal.Enabled = false;
                        lbMissieProfielBemanning.Enabled = false;
                        gbHOPE.Enabled = true;
                        gbSIN.Enabled = false;
                        gbMissie.Enabled = false;

                        // hier mogen ook de personen in de listboxen gevuld worden
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer een missieprofiel");
                }
            }
        }

        private void btnCancelMissieProfiel_Click(object sender, EventArgs e)
        {
            lbMissieProfielen.Enabled = true;
            lbMissieProfielMateriaal.Enabled = true;
            lbMissieProfielBemanning.Enabled = true;
            gbHOPE.Enabled = false;
            gbSIN.Enabled = false;
            gbMissie.Enabled = true;
        }


        // zoek de dichtsbijzijnde boot
        private void btnDichtstBijzijndeBoot_Click(object sender, EventArgs e)
        {
            lblDbBoot.Text = administratie.DitchtsbijzijndeBoot(Convert.ToInt32(nudXco.Value), Convert.ToInt32(nudYco.Value)).ToString();
        }

        private void btnVerwijderMissie_Click(object sender, EventArgs e)
        {
            //Missie missie = (Missie)lbMissies.SelectedItem as Missie;
            MessageBox.Show("nog niet geïmplementeerd");
        }

        private void btnKiesPersoon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nog niet geïmplementeerd");
        }

        private void btnKiesMateriaal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nog niet geïmplementeerd");
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

        private void VulPersonen(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach(Persoon p in administratie.Personen)
            {
                listbox.Items.Add(p);
            }
        }

        private void VulMateriaal(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach(Materiaal m in administratie.Materiaal)
            {
                listbox.Items.Add(m);
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
