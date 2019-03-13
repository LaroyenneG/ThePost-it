using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignPostItControler : AbstractControler
    {
        private readonly PostIt postIt;
        private bool isMoved;

        private Point mousePosition;

        public DesignPostItControler(Model model, PostitEditor view, int idModel) : base(model, view)
        {
            mousePosition = new Point(0, 0);
            postIt = model.GetPostItByID(idModel);
            isMoved = false;
        }

        public override void ActionEvent(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(TextBox)) return;

            var textBox = (TextBox) sender;

            MememtoSaveModel();
            postIt.SetText(textBox.Text);
        }

        public override void ActionMouseUp(object sender, MouseEventArgs e)
        {
            isMoved = false;
        }

        public override void ActionMouseMove(object sender, MouseEventArgs e)
        {
            if (view.CursorButtonIsChecked())
                if (e.Button == MouseButtons.Left)
                {
                    if (!isMoved) MememtoSaveModel();

                    var dx = e.X - mousePosition.X;
                    var dy = e.Y - mousePosition.Y;

                    postIt.Translate(dx, dy);

                    UpdateView();

                    isMoved = true;
                }
        }

        public override void ActionMouseDown(object sender, MouseEventArgs e)
        {
            if (view.CursorButtonIsChecked())
                if (e.Button == MouseButtons.Left)
                {
                    if ((Control.ModifierKeys & Keys.Shift) != Keys.Shift)
                    {
                        model.UnselectAll();
                        postIt.SetSelect(true);
                    }
                    else
                    {
                        postIt.SetSelect(!postIt.IsSelected());
                    }

                    model.PopUpPostIt(postIt);
                }

            UpdateView();

            mousePosition = e.Location;
        }
    }
}