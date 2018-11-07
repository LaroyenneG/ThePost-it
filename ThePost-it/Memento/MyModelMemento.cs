using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    public class MyModelMemento : IMemento
    {
        private Model model;

        private List<PostIt> savedState;


        public MyModelMemento(Model model)
        {
            this.model = model;
            this.savedState = model.GetCurrentState();
        }

        public IMemento Restore()
        {
            IMemento m = new MyModelMemento(this.model);
            model.SetState(savedState);
            return m;
        }

        public override string ToString()
        {
            string s = "In the memento : \n";
            foreach (PostIt pi in savedState)
            {
                s += "Post-it n°" + pi.GetID() + ":\n";
                pi.ToString();
            }
            return s;
        }
    }
}
