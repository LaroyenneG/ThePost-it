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

        public void SetMenuControler(MasterControler controler)
        {
            this.quitterToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.supprimerToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.annulerToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.retablirToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
        }

        public void SetDesignerControler(MasterControler controler)
        {
            this.panelDesigner.SetControler(controler);
        }

        public bool CursorButtonIsChecked()
        {
            return this.cursorButton.Checked;
        }

        public bool PostItButtonIsChecked()
        {
            return this.postItButton.Checked;
        }

        internal void SetOnePostItIsSelected(bool v)
        {
            this.supprimerToolStripMenuItem.Enabled = v;
        }

        internal void SetCanUndo(bool canUndo)
        {
            this.annulerToolStripMenuItem.Enabled = canUndo;
        }

        internal void SetCanRedo(bool canRedo)
        {
            this.retablirToolStripMenuItem.Enabled = canRedo;
        }
    }
}
