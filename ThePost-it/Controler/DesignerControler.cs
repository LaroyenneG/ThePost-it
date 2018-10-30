﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignerControler : MyControler
    {

        public DesignerControler(Model model, PostitEditor view) : base(model, view)
        {
           
        }

        public override void ActionMouseClick(Object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && view.PostItButtonIsChecked())
            {
                view.panelDesigner.LockPostIt();
                model.CreateNewPostit(e.X, e.Y);

                SaveModel();
            }
            else if (view.CursorButtonIsChecked())
            {
                view.panelDesigner.UnLockPostIt();
                model.UnselectAll();
            }

            UpdateView();
        }
    }
}
