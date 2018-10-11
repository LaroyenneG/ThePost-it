using System;
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
    public partial class PostitEditor : Form
    {
        public PostitEditor()
        {
            InitializeComponent();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CursorButton_CheckedChanged(object sender, EventArgs e)
        {
            this.panelDisigner.SetMode(false);
        }

        private void ItButton_CheckedChanged(object sender, EventArgs e)
        {
            this.panelDisigner.SetMode(true);
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelDisigner.supprime();
        }
    }
}
