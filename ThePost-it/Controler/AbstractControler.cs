using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThePost_it
{
    public abstract class AbstractControler
    {
        private static readonly UndoRedoHistory history = new UndoRedoHistory();
        private readonly PanelDesigner panelDesigner;

        protected Model model;
        protected PostitEditor view;

        public AbstractControler(Model model, PostitEditor view)
        {
            this.model = model;
            this.view = view;
            panelDesigner = view.GetPanelDesigner();
        }

        protected void UpdateView()
        {
            var removeList = new List<DesignPostIt>();

            foreach (var d in panelDesigner.GetDesignPostItList())
            {
                var p = model.GetPostItByID(d.GetID());
                if (p != null)
                {
                    d.Display(p);
                    panelDesigner.Controls.SetChildIndex(d, model.GetIndex(p));
                }
                else
                {
                    removeList.Add(d);
                }
            }

            panelDesigner.RemoveAll(removeList);

            foreach (var p in model.GetPostItList())
            {
                var find = false;

                foreach (var d in panelDesigner.GetDesignPostItList())
                    if (d.Correspond(p))
                    {
                        find = true;
                        break;
                    }

                if (!find) panelDesigner.CreateNewPostItDesigner(p, new DesignPostItControler(model, view, p.GetID()));
            }

            view.SetOnePostItIsSelected(model.OnePostItIsSelected());
            view.SetCanUndo(history.CanUndo);
            view.SetCanRedo(history.CanRedo);
        }

        protected void RestoreModel()
        {
            panelDesigner.Clear();

            if (history.CanRedo) history.Redo();
        }

        protected void CancelModel()
        {
            panelDesigner.Clear();

            if (history.CanUndo) history.Undo();
        }

        protected void MememtoSaveModel()
        {
            history.Do(new MyModelMemento(model));
        }

        public virtual void ActionEvent(object sender, EventArgs e)
        {
        }

        public virtual void ActionMouseClick(object sender, MouseEventArgs e)
        {
        }

        public virtual void ActionMouseMove(object sender, MouseEventArgs e)
        {
        }

        public virtual void ActionMouseUp(object sender, MouseEventArgs e)
        {
        }

        public virtual void ActionMouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}