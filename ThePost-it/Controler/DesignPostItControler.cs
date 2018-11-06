using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignPostItControler : MasterControler
    {

        private int idModel;
        private Point mousePosition;

        public DesignPostItControler(Model model, PostitEditor view, int idModel) : base(model, view)
        {
            mousePosition = new Point(0, 0);
            this.idModel = idModel;
        }

        public override void ActionEvent(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(TextBox))
            {
                return;
            }

            SaveModelBeforeModifications();

            TextBox textBox = (TextBox)sender;

            PostIt p = model.GetPostItByID(idModel);

            if (p != null)
            {
                p.SetText(textBox.Text);
            }

            SaveModelAfterModifications();
        }

        public override void ActionMouseUp(object sender, MouseEventArgs e)
        {
            SaveModelAfterModifications();
        }


        public override void ActionMouseMove(Object sender, MouseEventArgs e)
        {
            PostIt p = model.GetPostItByID(idModel);

            if (p != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int dx = e.X - mousePosition.X;
                    int dy = e.Y - mousePosition.Y;

                    p.Translate(dx, dy);

                    UpdateView();
                }
            }
        }

        public override void ActionMouseDown(Object sender, MouseEventArgs e)
        {
            SaveModelBeforeModifications();

            PostIt p = model.GetPostItByID(idModel);

            if (p != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if ((Control.ModifierKeys & Keys.Shift) != Keys.Shift)
                    {
                        model.UnselectAll();
                    }

                    p.SetSelect(true);
                    model.PopUpPostIt(p);
                }

                UpdateView();
            }

            mousePosition = e.Location;
        }
    }
}
