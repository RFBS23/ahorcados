﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcados
{
    public partial class mensajerobot : Form
    {
        public mensajerobot()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            gano ganarsms = new gano();
            ganarsms.Show();
            this.Hide();
        }
    }
}