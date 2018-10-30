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
    }
}
