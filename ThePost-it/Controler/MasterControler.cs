using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public abstract class MasterControler
    {
        private static UndoRedoHistory history = new UndoRedoHistory();

        protected Model model;
        protected PostitEditor view;

        public MasterControler(Model model, PostitEditor view)
        {
            this.model = model;
            this.view = view;
        }

        protected void UpdateView()
        {

            List<DesignPostIt> removeList = new List<DesignPostIt>();

            foreach (DesignPostIt d in view.panelDesigner.GetDesignPostItList())
            {
                PostIt p = model.GetPostItByID(d.GetID());
                if (p != null)
                {
                    d.Display(p);
                    view.panelDesigner.Controls.SetChildIndex(d, model.GetIndex(p));
                }
                else
                {
                    removeList.Add(d);
                }
            }

            view.panelDesigner.RemoveAll(removeList);

            foreach (PostIt p in model.GetPostItList())
            {
                bool find = false;

                foreach (DesignPostIt d in view.panelDesigner.GetDesignPostItList())
                {
                    if (d.Correspond(p))
                    {
                        find = true;
                        break;
                    }
                }

                if (!find)
                {
                    view.panelDesigner.CreateNewPostItDesigner(p, new DesignPostItControler(model, view, p.GetID()));
                }
            }

            view.SetOnePostItIsSelected(model.OnePostItIsSelected());
            view.SetCanUndo(history.CanUndo);
            view.SetCanRedo(history.CanRedo);
        }

        protected void RestoreModel()
        {
            if (history.CanRedo)
            {
                history.Redo();
            }
        }

        protected void CancelModel()
        {
            if (history.CanUndo)
            {
                history.Undo();
            }
        }

        protected void MememtoSaveModel()
        {
            history.Do(new MyModelMemento(model));
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
