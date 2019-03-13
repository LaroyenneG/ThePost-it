using System;
using System.Collections.Generic;

public class UndoRedoHistory
{
    private readonly Stack<IMemento> redoStack;
    private readonly Stack<IMemento> undoStack;
    private bool inUndoRedo;

    public UndoRedoHistory()
    {
        undoStack = new Stack<IMemento>();
        redoStack = new Stack<IMemento>();
    }

    public bool CanUndo => undoStack.Count > 0;

    public bool CanRedo => redoStack.Count > 0;

    public void Undo()
    {
        inUndoRedo = true;
        var top = undoStack.Pop();
        redoStack.Push(top.Restore());
        inUndoRedo = false;
    }

    public void Redo()
    {
        inUndoRedo = true;
        var top = redoStack.Pop();
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
        undoStack.Push(m);
    }
}