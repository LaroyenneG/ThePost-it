using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    public class Memento : IMemento
    {
        private Model model;

        private List<PostIt> savedlist;

        public Memento() : this(new Model())
        {

        }

        public Memento(Model model)
        {
            this.model = model;

            savedlist = new List<PostIt>();

            foreach(PostIt p in model.GetPostItList())
            {
                savedlist.Add((PostIt)p.Clone());
            }
        }

        public List<PostIt> GetSavedListPostIt()
        {
            return savedlist;
        }

        public IMemento Restore()
        {
            model.restoreFromMemento(this);
            return this;
        }

        public override bool Equals(object obj)
        {
            Memento memento = obj as Memento;


            if(memento.savedlist.Count  != savedlist.Count)
            {
                return false;
            }

            for(int i=0; i< savedlist.Count; i++)
            {
                if(!savedlist.ElementAt(i).Equals(memento.savedlist.ElementAt(i))) {
                    return false;
                }
            }

            return true;
        }


        public override string ToString()
        {
            return savedlist.ToString();
        }
    }
}
