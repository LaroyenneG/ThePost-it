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

            listPostit.Add(p);

            return p;
        }

        public PostIt GetPostItByID(int id)
        {

            foreach(PostIt p in listPostit)
            {
                if(p.GetID()==id)
                {
                    return p;
                }
            }

            return null;
        }

        public void DeleteSelectedPostIts()
        {
            listPostit.RemoveAll(delegate (PostIt p) {
                return p.IsSelected();
            });
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
    }
}
