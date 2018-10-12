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

        public void SetMenuControler(MyControler controler) 
        {
            this.quitterToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.supprimerToolStripMenuItem.Click += new EventHandler(controler.ActionEvent);
            this.postItButton.Click += new EventHandler(controler.ActionEvent);
            this.cursorButton.Click += new EventHandler(controler.ActionEvent);
        }

        public void SetDesignerControler(MyControler controler)
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
    }
}
