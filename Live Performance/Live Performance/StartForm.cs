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
    public partial class StartForm : Form
    {
        // Fields / Properties
        private Administratie administratie;

        // Constructor(s)
        public StartForm()
        {
            InitializeComponent();
            administratie = new Administratie();
        }        

        // Event Handlers
        #region EventHandlers


        #endregion
        
        // inloggen van een persoon
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbInlogNaam.Text != "" && tbWachtwoord.Text != "")
            {
                // als het inloggen gelukt is wijzig dan de nu ingelogde persoon en ga naar het volgende scherm
                if (!administratie.LogIn(tbInlogNaam.Text, tbWachtwoord.Text))
                {
                    MessageBox.Show("Inlognaam / wachtwoordcombinatie ongeldig");
                }
                else
                {
                    administratie.NuIngelogd = administratie.GeefPersoon(tbInlogNaam.Text);
                    BeheerForm beheerForm = new BeheerForm();
                    beheerForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Voer uw inlognaam en wachtwoord in");
            }

        }

        // Methoden
        #region Methoden


        #endregion
    }
}
