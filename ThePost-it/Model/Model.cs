using System.Collections.Generic;

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
            var p = new PostIt(x, y);

            listPostit.Insert(0, p);

            return p;
        }

        public List<PostIt> GetCurrentState()
        {
            var list = new List<PostIt>();

            foreach (var p in listPostit) list.Add((PostIt) p.Clone());

            return list;
        }

        public PostIt GetPostItByID(int id)
        {
            foreach (var p in listPostit)
                if (p.GetID() == id)
                    return p;

            return null;
        }

        public void DeleteSelectedPostIts()
        {
            listPostit.RemoveAll(delegate(PostIt p) { return p.IsSelected(); });
        }

        public int GetIndex(PostIt p)
        {
            return listPostit.IndexOf(p);
        }

        public void UnselectAll()
        {
            foreach (var p in listPostit) p.SetSelect(false);
        }

        public List<PostIt> GetPostItList()
        {
            return listPostit;
        }

        public void SetState(List<PostIt> listPostit)
        {
            this.listPostit = listPostit;
        }


        public void PopUpPostIt(PostIt p)
        {
            if (listPostit.Remove(p)) listPostit.Insert(0, p);
        }

        public bool OnePostItIsSelected()
        {
            foreach (var p in listPostit)
                if (p.IsSelected())
                    return true;

            return false;
        }

        public override string ToString()
        {
            var s = "This model : \n";
            s += "List of Post-It : \n";
            foreach (var p in listPostit)
            {
                s += "Post-it n°" + p.GetID() + ":\n";
                p.ToString();
                if (p.IsSelected()) s += "is selected \n";
            }

            return s;
        }
    }
}