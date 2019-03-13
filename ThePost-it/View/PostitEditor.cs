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
            quitterToolStripMenuItem.Click += controler.ActionEvent;
            supprimerToolStripMenuItem.Click += controler.ActionEvent;
            annulerToolStripMenuItem.Click += controler.ActionEvent;
            retablirToolStripMenuItem.Click += controler.ActionEvent;
        }

        public void SetDesignerControler(AbstractControler controler)
        {
            panelDesigner.SetControler(controler);
        }

        public bool CursorButtonIsChecked()
        {
            return cursorButton.Checked;
        }

        public bool PostItButtonIsChecked()
        {
            return postItButton.Checked;
        }

        public void SetOnePostItIsSelected(bool v)
        {
            supprimerToolStripMenuItem.Enabled = v;
        }

        public void SetCanUndo(bool canUndo)
        {
            annulerToolStripMenuItem.Enabled = canUndo;
        }

        public void SetCanRedo(bool canRedo)
        {
            retablirToolStripMenuItem.Enabled = canRedo;
        }

        public PanelDesigner GetPanelDesigner()
        {
            return panelDesigner;
        }
    }
}