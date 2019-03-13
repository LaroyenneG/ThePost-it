public interface IMemento
{
    IMemento Restore();
    // Restore restaure l'état conservé dans ce Mémento
    // Le Mémento retourné contient l'état avant restauration et
    // facilite l'écriture de l'opération Redo
}