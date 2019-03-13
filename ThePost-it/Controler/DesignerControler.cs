using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignerControler : AbstractControler
    {
        private PanelDesigner panelDesigner;

        public DesignerControler(Model model, PostitEditor view) : base(model, view)
        {
            panelDesigner = view.GetPanelDesigner();
        }

        public override void ActionMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && view.PostItButtonIsChecked())
            {
                MememtoSaveModel();
                model.CreateNewPostit(e.X, e.Y);
            }
            else if (view.CursorButtonIsChecked())
            {
                model.UnselectAll();
            }

            UpdateView();
        }
    }
}