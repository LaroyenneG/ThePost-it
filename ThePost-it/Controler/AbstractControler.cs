using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public abstract class AbstractControler
    {
        private static UndoRedoHistory history = new UndoRedoHistory();

        protected Model model;
        protected PostitEditor view;
        private PanelDesigner panelDesigner;

        public AbstractControler(Model model, PostitEditor view)
        {
            this.model = model;
            this.view = view;
            this.panelDesigner = view.GetPanelDesigner();
        }

        protected void UpdateView()
        {
            List<DesignPostIt> removeList = new List<DesignPostIt>();

            foreach (DesignPostIt d in panelDesigner.GetDesignPostItList())
            {
                PostIt p = model.GetPostItByID(d.GetID());
                if (p != null)
                {
                    d.Display(p);
                    this.panelDesigner.Controls.SetChildIndex(d, model.GetIndex(p));
                }
                else
                {
                    removeList.Add(d);
                }
            }

            this.panelDesigner.RemoveAll(removeList);

            foreach (PostIt p in model.GetPostItList())
            {
                bool find = false;

                foreach (DesignPostIt d in panelDesigner.GetDesignPostItList())
                {
                    if (d.Correspond(p))
                    {
                        find = true;
                        break;
                    }
                }

                if (!find)
                {
                    this.panelDesigner.CreateNewPostItDesigner(p, new DesignPostItControler(model, view, p.GetID()));
                }
            }
          
            this.view.SetOnePostItIsSelected(model.OnePostItIsSelected());
            this.view.SetCanUndo(history.CanUndo);
            this.view.SetCanRedo(history.CanRedo);
        }

        protected void RestoreModel()
        {
            this.panelDesigner.Clear();

            if (history.CanRedo)
            {
                history.Redo();
            }
        }

        protected void CancelModel()
        {
            this.panelDesigner.Clear();

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
