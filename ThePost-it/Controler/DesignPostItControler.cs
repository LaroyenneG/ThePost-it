using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignPostItControler : AbstractControler
    {

        private PostIt postIt;

        private Point mousePosition;

        private bool isMoved;

        public DesignPostItControler(Model model, PostitEditor view, int idModel) : base(model, view)
        {
            this.mousePosition = new Point(0, 0);
            this.postIt = model.GetPostItByID(idModel);
            this.isMoved = false;
        }

        public override void ActionEvent(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(TextBox))
            {
                return;
            }

            TextBox textBox = (TextBox)sender;

            this.MememtoSaveModel();
            this.postIt.SetText(textBox.Text);
        }

        public override void ActionMouseUp(object sender, MouseEventArgs e)
        {
            this.isMoved = false;
        }

        public override void ActionMouseMove(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!this.isMoved)
                {
                    this.MememtoSaveModel();
                }

                int dx = e.X - mousePosition.X;
                int dy = e.Y - mousePosition.Y;

                this.postIt.Translate(dx, dy);

                this.UpdateView();

                this.isMoved = true;
            }
        }

        public override void ActionMouseDown(Object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if ((Control.ModifierKeys & Keys.Shift) != Keys.Shift)
                {
                    model.UnselectAll();
                    this.postIt.SetSelect(true);
                }
                else
                {
                    this.postIt.SetSelect(!this.postIt.IsSelected());
                }

                this.model.PopUpPostIt(this.postIt);
            }

            this.UpdateView();

            this.mousePosition = e.Location;
        }
    }
}
