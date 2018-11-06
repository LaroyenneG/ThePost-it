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
            this.listPostit = new List<PostIt>();
        }


        public PostIt CreateNewPostit(int x, int y)
        {
            PostIt p = new PostIt(x, y);

            this.listPostit.Insert(0, p);

            return p;
        }

        public List<PostIt> GetCurrentState()
        {
            List<PostIt> list = new List<PostIt>();

            foreach (PostIt p in listPostit)
            {
                list.Add((PostIt)p.Clone());
            }

            return list;
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
            return this.listPostit.IndexOf(p);
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
            return this.listPostit;
        }

        public void SetState(List<PostIt> listPostit)
        {
            this.listPostit = listPostit;
        }


        public void PopUpPostIt(PostIt p)
        {
            if (this.listPostit.Remove(p))
            {
                this.listPostit.Insert(0, p);
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
            foreach (PostIt p in listPostit)
            {
                s += "Post-it n°" + p.GetID() + ":\n";
                p.ToString();
                if (p.IsSelected())
                {
                    s += "is selected \n";
                }
            }
            return s;
        }
    }
}
