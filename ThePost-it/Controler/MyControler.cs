using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public abstract class MyControler
    {

        protected Model model;
        protected PostitEditor view;

        public MyControler(Model model, PostitEditor view)
        {
            this.model = model;
            this.view = view;
        }

        protected void UpdateView()
        {

            List<DesignPostIt> removeList = new List<DesignPostIt>();

            foreach(DesignPostIt d in view.panelDesigner.GetDesignPostItList())
            {
                PostIt p = model.GetPostItByID(d.GetID());
                if(p!=null)
                {
                    d.Display(p);
                }
                else
                {
                    removeList.Add(d);
                }
            }

            view.panelDesigner.RemoveAll(removeList);


            foreach(PostIt p in model.GetPostItList())
            {
                bool find = false;

                foreach (DesignPostIt d in view.panelDesigner.GetDesignPostItList())
                {
                    if(d.Correspond(p)) {
                        find = true;
                        break;
                    }
                }

                if(!find)
                {
                    //DesignPostItControler designerControler = ;
                    view.panelDesigner.CreateNewPostItDesigner(p, new DesignPostItControler(model, view, p.GetID()));
                }
            }
        }

        public virtual void ActionEvent(Object sender, EventArgs e)
        {

        }

        public virtual void ActionMouseClick(Object sender, MouseEventArgs e)
        {

        }

        public virtual void ActionMouseMove(Object sender, MouseEventArgs e)
        {

        }

        public virtual void ActionMouseUp(Object sender, MouseEventArgs e)
        {

        }

        public virtual void ActionMouseDown(Object sender, MouseEventArgs e)
        {

        }
    }
}
