using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace završnaVježba
{
    public partial class vrstaPica : Form
    {
        public vrstaPica()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            odabir odabir = new odabir();
            odabir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bezalkPica bezalk = new bezalkPica();
            bezalk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alkPica alkPica = new alkPica();
            alkPica.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gaziranaPica gazirana = new gaziranaPica();
            gazirana.Show();
        }
    }
}
