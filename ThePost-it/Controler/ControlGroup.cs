using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    public class ControlGroup
    {
        public ControlGroup(Model model, PostitEditor postitEditor)
        {
            postitEditor.SetMenuControler(new MenuControler(model, postitEditor));
            postitEditor.SetDesignerControler(new DesignerControler(model, postitEditor));
        }
    }
}
