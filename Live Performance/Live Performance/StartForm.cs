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
        DatabaseKoppeling databaseKoppeling;

        // Constructor(s)
        public StartForm()
        {
            InitializeComponent();
            databaseKoppeling = new DatabaseKoppeling();           
            if(!databaseKoppeling.TestConnectie())
            {
                MessageBox.Show("Verbinding Mislukt");
            }
            else
            {
                MessageBox.Show("Verbinding Gelukt");
            }
        }

        // Event Handlers
        #region EventHandlers


        #endregion

        // Methoden
        #region Methoden


        #endregion
    }
}
