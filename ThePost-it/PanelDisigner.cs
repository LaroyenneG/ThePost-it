using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThePost_it
{

    public class PanelDisigner : Panel
    {
        private List<Post_it> listPostit;

        public PanelDisigner()
        {
            listPostit = new List<Post_it>();

            this.MouseClick += new MouseEventHandler(ActionMouseClick);
        }

        public void LoadModel()
        {

            this.Controls.Clear();

            foreach (Post_it p in listPostit)
            {
                this.Controls.Add(new DesignPost_It(p));
            }
        }

        public void ActionMouseClick(Object sender, MouseEventArgs e)
        {
            listPostit.Add(new Post_it(e.Location.X, e.Location.Y));

            LoadModel();
        }
    }
}