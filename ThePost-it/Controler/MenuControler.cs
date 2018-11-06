using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{

    class MenuControler : AbstractControler
    {

        public MenuControler(Model model, PostitEditor view) : base(model, view)
        {
        }

        public override void ActionEvent(object sender, EventArgs e)
        {

            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;

                switch (item.Name)
                {
                    case Constant.NAME_ITEM_QUITTER:
                        this.QuitterToolStripMenuItem_Click(sender, e);
                        break;

                    case Constant.NAME_ITEM_SUPPRIMER:
                        this.SupprimerToolStripMenuItem_Click(sender, e);
                        break;

                    case Constant.NAME_ITEM_ANNULER:
                        this.AnnulerToolStripMenuItem_Click(sender, e);
                        break;

                    case Constant.NAME_ITEM_RETABLIR:
                        this.RetablirToolStripMenuItem_Click(sender, e);
                        break;

                    default:
                        Console.WriteLine("Error unknow name : " + item.Name);
                        break;
                }
            }

            this.UpdateView();
        }


        private void AnnulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CancelModel();
        }

        private void RetablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RestoreModel();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.model.OnePostItIsSelected())
            {
                this.MememtoSaveModel();
                this.model.DeleteSelectedPostIts();
            }
        }
    }
}
