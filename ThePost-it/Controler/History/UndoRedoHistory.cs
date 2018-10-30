using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    public class UndoRedoHistory
    {
       private Stack<IMemento> undoStack;
       private Stack<IMemento> redoStack;
       private bool inUndoRedo;

        public UndoRedoHistory()
        {
            undoStack = new Stack<IMemento>();
            redoStack = new Stack<IMemento>();
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
            inUndoRedo = true;
            IMemento top = undoStack.Pop();
            redoStack.Push(top.Restore());
            inUndoRedo = false;
        }

        public void Redo()
        {
            inUndoRedo = true;
            IMemento top = redoStack.Pop();
            undoStack.Push(top.Restore());
            inUndoRedo = false;
        }

        public void Do(IMemento m)
        {

            if (inUndoRedo)
                throw new InvalidOperationException(
                    "Invoking do within an undo/redo action.");
            // On ne peut réaliser une nouvelle opération pendant
            // l'annulation ou le rétablissement d'une autre
            redoStack.Clear();
            // La pile de rétablissement est vidée lorsqu'une nouvelle
            // opération est réalisée

            if(undoStack.Count<=0 || !undoStack.Peek().Equals(m))
            {
                undoStack.Push(m);
            }

            Console.WriteLine(this);
        }


        public override string ToString()
        {
            string s="";

            foreach(IMemento m in undoStack)
            {
                s += "#";
            }

            return s;
        }
    }
}
