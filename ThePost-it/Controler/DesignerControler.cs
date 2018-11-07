using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignerControler : AbstractControler
    {
        private PanelDesigner panelDesigner;

        public DesignerControler(Model model, PostitEditor view) : base(model, view)
        {
            this.panelDesigner = view.GetPanelDesigner();
        }

        public override void ActionMouseClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && view.PostItButtonIsChecked())
            {
                this.MememtoSaveModel();
                this.model.CreateNewPostit(e.X, e.Y);
            }
            else if (view.CursorButtonIsChecked())
            {
                this.model.UnselectAll();
            }
         
            this.UpdateView();
        }
    }
}
