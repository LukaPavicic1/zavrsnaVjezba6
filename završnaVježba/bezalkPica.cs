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
    public partial class bezalkPica : Form
    {
        public bezalkPica()
        {
            InitializeComponent();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            vrstaPica pice = new vrstaPica();
            pice.Show();
        }
    }
}
