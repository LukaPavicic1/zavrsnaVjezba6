﻿using System;
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
    public partial class hladJela : Form
    {
        public hladJela()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            narudzbaForm narudzba = new narudzbaForm();
            narudzba.Show();
        }
    }
}
