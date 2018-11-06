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

        public void SetMenuControler(AbstractControler controler)
        {
            this.quitterToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.supprimerToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.annulerToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.retablirToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
        }

        public void SetDesignerControler(AbstractControler controler)
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

        public void SetOnePostItIsSelected(bool v)
        {
            this.supprimerToolStripMenuItem.Enabled = v;
        }

        public void SetCanUndo(bool canUndo)
        {
            this.annulerToolStripMenuItem.Enabled = canUndo;
        }

        public void SetCanRedo(bool canRedo)
        {
            this.retablirToolStripMenuItem.Enabled = canRedo;
        }

        public PanelDesigner GetPanelDesigner()
        {
            return panelDesigner;
        }
    }
}
