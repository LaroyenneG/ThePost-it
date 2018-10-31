using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    public class UndoRedoHistory
    {

        private readonly object mutex = new object();

        private Stack<IMemento> undoStack;
        private Stack<IMemento> redoStack;

        private IMemento tmp;

        public UndoRedoHistory()
        {
            undoStack = new Stack<IMemento>();
            redoStack = new Stack<IMemento>();
            tmp = null;
        }

        public bool CanUndo
        {
            get
            {
                return undoStack.Count > 0;
            }
        }

        public bool CanRedo
        {
            get
            {
                return redoStack.Count > 0;
            }
        }

        public void Undo()
        {
            lock (mutex)
            {
                tmp = null;
                IMemento top = undoStack.Pop();
                redoStack.Push(top.Restore());
            }
        }

        public void Redo()
        {
            lock (mutex)
            {
                tmp = null;
                IMemento top = redoStack.Pop();
                undoStack.Push(top.Restore());
            }
        }

        public void PrepareTransaction(IMemento m)
        {
            lock (mutex)
            {
                tmp = m;
            }
        }

        public void CloseTransaction(IMemento m)
        {
            lock (mutex)
            {
                if (tmp != null && !tmp.Equals(m))
                {
                    Do(tmp);
                }

                tmp = null;
            }
        }

        public void Do(IMemento m)
        {
            lock (mutex)
            {

                redoStack.Clear();
                // La pile de rétablissement est vidée lorsqu'une nouvelle
                // opération est réalisée

                if (!(undoStack.Count >= 1 && undoStack.Peek().Equals(m)))
                {
                    undoStack.Push(m);
                }
            }
        }


        public override string ToString()
        {
            string s = "--------------------------\n";

            s += "undo :";
            foreach (IMemento m in undoStack)
            {
                s += "#";
            }

            s += "\nredo:";
            foreach (IMemento m in redoStack)
            {
                s += "#";
            }

            return s;
        }
    }
}
