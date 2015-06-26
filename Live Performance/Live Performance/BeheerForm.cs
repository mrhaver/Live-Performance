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
    public partial class BeheerForm : Form
    {
        private Administratie administratie;
        public BeheerForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            label1.Text = administratie.NuIngelogd.PersoneelType;
        }
    }
}
