﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cursorButton_CheckedChanged(object sender, EventArgs e)
        {
            this.panelDisigner.SetMode(false);
        }

        private void ItButton_CheckedChanged(object sender, EventArgs e)
        {
            this.panelDisigner.SetMode(true);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelDisigner.supprime();
        }
    }
}
