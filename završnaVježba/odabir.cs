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
    public partial class odabir : Form
    {
        public odabir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            narudzbaForm narudzba = new narudzbaForm();
            narudzba.Show();

            odabir odabir = new odabir();
            odabir.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odabirStola stol = new odabirStola();
            stol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vrstaPica pice = new vrstaPica();
            pice.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
