using System.Collections.Generic;
using System.Windows.Forms;

namespace ThePost_it
{
    public class PanelDesigner : Panel
    {
        public void RemoveAll(List<DesignPostIt> list)
        {
            foreach (var d in list) Remove(d);
        }

        public void Clear()
        {
            Controls.Clear();
        }

        public void Remove(DesignPostIt d)
        {
            Controls.Remove(d);
        }

        public DesignPostIt CreateNewPostItDesigner(PostIt p, AbstractControler controler)
        {
            var design = new DesignPostIt(p);

            Controls.Add(design);
            Controls.SetChildIndex(design, 0);

            design.SetControler(controler);

            return design;
        }

        public void SetControler(AbstractControler controler)
        {
            MouseClick += controler.ActionMouseClick;
        }

        public List<DesignPostIt> GetDesignPostItList()
        {
            var listDesign = new List<DesignPostIt>();

            foreach (Control c in Controls) listDesign.Add((DesignPostIt) c);

            return listDesign;
        }
    }
}