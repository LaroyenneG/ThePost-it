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

            foreach (PostIt p in model.GetPostItList())
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

            if (memento.savedlist.Count != savedlist.Count)
            {
                return false;
            }

            foreach (PostIt p1 in savedlist)
            {
                bool find = false;

                foreach (PostIt p2 in memento.savedlist)
                {
                    if (p1.Equals(p2))
                    {
                        find = true;
                        break;
                    }
                }

                if (!find)
                {
                    return false;
                }
            }

            return true;
        }


        public override string ToString()
        {
            string s = "In the memento : \n";
            foreach (PostIt pi in savedlist)
            {
                s += "Post-it n°" + pi.GetID() + ":\n";
                pi.ToString();
            }
            return s;
        }
    }
}
