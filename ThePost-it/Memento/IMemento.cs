using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IMemento
{
    IMemento Restore();
    // Restore restaure l'état conservé dans ce Mémento
    // Le Mémento retourné contient l'état avant restauration et
    // facilite l'écriture de l'opération Redo

}

