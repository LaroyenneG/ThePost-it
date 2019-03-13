using System.Collections.Generic;

namespace ThePost_it
{
    public class MyModelMemento : IMemento
    {
        private readonly Model model;

        private readonly List<PostIt> savedState;


        public MyModelMemento(Model model)
        {
            this.model = model;
            savedState = model.GetCurrentState();
        }

        public IMemento Restore()
        {
            IMemento m = new MyModelMemento(model);
            model.SetState(savedState);
            return m;
        }

        public override string ToString()
        {
            var s = "In the memento : \n";
            foreach (var pi in savedState)
            {
                s += "Post-it n°" + pi.GetID() + ":\n";
                pi.ToString();
            }

            return s;
        }
    }
}