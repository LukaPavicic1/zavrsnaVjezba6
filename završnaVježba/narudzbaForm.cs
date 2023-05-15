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
    public partial class narudzbaForm : Form
    {
        public narudzbaForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            odabir odabir = new odabir();   
            odabir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            juhe juhe = new juhe();
            juhe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hladJela hlad = new hladJela();
            hlad.Show();

        }
    }
}
