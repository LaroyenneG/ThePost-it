using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThePost_it
{

    public class PanelDisigner : Panel
    {

        private bool mode; // false = selection ; true = create

        private List<Post_it> listPostit;
        private List<DesignPost_It> listDesign;

        public PanelDisigner()
        {
            mode = false;
            listPostit = new List<Post_it>();
            listDesign = new List<DesignPost_It>();
            this.MouseClick += new MouseEventHandler(ActionMouseClick);
        }

        private void AddPost_It(Post_it p)
        {
            DesignPost_It design = new DesignPost_It(p);
            this.Controls.Add(design);
            this.Controls.SetChildIndex(design, 0);
            listPostit.Add(p);
            listDesign.Add(design);
        }

        private void LockPost_It()
        {
            foreach(DesignPost_It d in listDesign)
            {
                d.LockFocus();
            }
        }

        private void UnLockPost_It()
        {
            foreach (DesignPost_It d in listDesign)
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
        }

        public void SetMode(bool mode)
        {

            if(mode)
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