using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThePost_it
{

    public class PanelDisigner : Panel
    {

        private bool mode; // false = selection ; true = create

        private List<Post_it> listPostit;
        private List<DesignPostIt> listDesign;

        public PanelDisigner()
        {
            mode = false;
            listPostit = new List<Post_it>();
            listDesign = new List<DesignPostIt>();
            this.MouseClick += new MouseEventHandler(ActionMouseClick);
        }

        private void AddPost_It(Post_it p)
        {
            DesignPostIt design = new DesignPostIt(p);
            this.Controls.Add(design);
            this.Controls.SetChildIndex(design, 0);
            listPostit.Add(p);
            listDesign.Add(design);
        }

        private void LockPost_It()
        {
            foreach (DesignPostIt d in listDesign)
            {
                d.LockFocus();
            }
        }

        private void UnLockPost_It()
        {
            foreach (DesignPostIt d in listDesign)
            {
                d.UnLockFocus();
            }
        }


        public void LoadModel()
        {
            this.Controls.Clear();

            foreach (Post_it p in listPostit)
            {
                AddPost_It(p);
            }
        }

        public void ActionMouseClick(Object sender, MouseEventArgs e)
        {
            if (mode)
            {
                AddPost_It(new Post_it(e.Location.X, e.Location.Y));
            }
            else
            {
                foreach (DesignPostIt d in listDesign)
                {
                    d.Deseleted();
                }
            }
        }


        public void supprime()
        {
            foreach (DesignPostIt d in listDesign)
            {
                if (d.IsSelect())
                {
                    this.Controls.Remove(d);
                }
            }
        }



        public void SetMode(bool mode)
        {

            if (mode)
            {
                LockPost_It();
            }
            else
            {
                UnLockPost_It();
            }

            this.mode = mode;
        }
    }
}