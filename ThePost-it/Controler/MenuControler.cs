using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{

    class MenuControler : MyControler
    {
        public MenuControler(Model model, PostitEditor view) : base(model, view)
        {

        }

        public override void ActionEvent(object sender, EventArgs e)
        {
            Control control = (Control) sender;

            switch (control.Name)
            {
                case "Quiter" :
                    QuitterToolStripMenuItem_Click(sender, e);
                    break;

                case "Supprimer" :
                    SupprimerToolStripMenuItem_Click(sender, e);
                    break;

                case "cursorButton":
                    CursorButton_CheckedChanged(sender, e);
                    break;

                case "postItButton":
                    ItButton_CheckedChanged(sender, e);
                    break;

                default :
                    Console.WriteLine("Error unknow name : " + control.Name);
                    break;
            }

            UpdateView();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CursorButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ItButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.DeleteSelectedPostIts();
        }
    }
}
