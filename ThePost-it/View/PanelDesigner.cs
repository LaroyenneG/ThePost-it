﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThePost_it
{

    public class PanelDesigner : Panel
    {

        public PanelDesigner()
        {
        }

        public void RemoveAll(List<DesignPostIt> list)
        {
            foreach (DesignPostIt d in list)
            {
                this.Remove(d);
            }
        }

        public void Clear()
        {
            this.Controls.Clear();
        }

        public void Remove(DesignPostIt d)
        {
            this.Controls.Remove(d);
        }

        public DesignPostIt CreateNewPostItDesigner(PostIt p, AbstractControler controler)
        {
            DesignPostIt design = new DesignPostIt(p);

            this.Controls.Add(design);
            this.Controls.SetChildIndex(design, 0);

            design.SetControler(controler);

            return design;
        }

        public void SetControler(AbstractControler controler)
        {
            this.MouseClick += new MouseEventHandler(controler.ActionMouseClick);
        }

        public List<DesignPostIt> GetDesignPostItList()
        {
            List<DesignPostIt> listDesign = new List<DesignPostIt>();

            foreach (Control c in this.Controls)
            {
                listDesign.Add((DesignPostIt)c);
            }

            return listDesign;
        }
    }
}