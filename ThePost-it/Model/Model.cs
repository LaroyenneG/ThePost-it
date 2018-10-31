using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    public class Model
    {

        private List<PostIt> listPostit;

        public Model()
        {
            listPostit = new List<PostIt>();
        }


        public PostIt CreateNewPostit(int x, int y)
        {
            PostIt p = new PostIt(x, y);

            listPostit.Insert(0, p);

            return p;
        }

        public PostIt GetPostItByID(int id)
        {

            foreach (PostIt p in listPostit)
            {
                if (p.GetID() == id)
                {
                    return p;
                }
            }

            return null;
        }

        public void DeleteSelectedPostIts()
        {
            listPostit.RemoveAll(delegate (PostIt p)
            {
                return p.IsSelected();
            });
        }

        public int GetIndex(PostIt p)
        {
            return listPostit.IndexOf(p);
        }

        public void UnselectAll()
        {
            foreach (PostIt p in listPostit)
            {
                p.SetSelect(false);
            }
        }

        public List<PostIt> GetPostItList()
        {
            return listPostit;
        }

        public void restoreFromMemento(Memento memento)
        {
            this.listPostit = memento.GetSavedListPostIt();
        }


        public void PopUpPostIt(PostIt p)
        {
            if (listPostit.Remove(p))
            {
                listPostit.Insert(0, p);
            }
        }

        public bool OnePostItIsSelected()
        {
            foreach (PostIt p in listPostit)
            {
                if (p.IsSelected())
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string s = "This model : \n";
            s += "List of Post-It : \n";
            foreach(PostIt pi in listPostit)
            {
                s += "Post-it n°" + pi.GetID() + ":\n";
                pi.ToString();
                if (pi.IsSelected())
                {
                    s += "is selected \n";
                }
            }
            return s;
        }
    }
}
