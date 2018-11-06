using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignPostIt : Panel
    {
        private int idModel;

        private TextBox tb;

        private const int MARGIN_SIZE = 15;
        private static Color DEFAULT_COLOR = Color.Yellow;
        private static Size POST_SIZE = new Size(300, 300);

        public DesignPostIt(PostIt p)
        {
            this.idModel = p.GetID();
            this.InitializeComponent();
            this.Controls.Add(tb);
            this.Display(p);
        }


        private void InitializeComponent()
        {
            this.Size = POST_SIZE;
            this.MaximumSize = POST_SIZE;
            this.MaximumSize = POST_SIZE;
            this.MinimumSize = POST_SIZE;
            this.tb = new TextBox();
            this.tb.Size = new Size(POST_SIZE.Width - MARGIN_SIZE * 2, POST_SIZE.Height - MARGIN_SIZE * 2);
            this.tb.BorderStyle = BorderStyle.None;
            this.BorderStyle = BorderStyle.None;
            this.SetColor(DEFAULT_COLOR);
            this.tb.Multiline = true;
            this.tb.Location = new Point(MARGIN_SIZE, MARGIN_SIZE);
            this.LockFocus();
        }

        public void Display(PostIt postIt)
        {
            if (postIt.GetText() != this.tb.Text)
            {
                this.tb.Text = postIt.GetText();
            }

            this.Location = new Point(postIt.GetX(), postIt.GetY());

            if (postIt.IsSelected())
            {
                this.Selected();
            }
            else
            {
                this.Deseleted();
            }
        }

        private void SetColor(Color color)
        {
            this.BackColor = color;
            this.tb.BackColor = color;
        }

        public void Selected()
        {
            this.BackColor = Color.Gold;
        }

        public void Deseleted()
        {
            this.BackColor = DEFAULT_COLOR;
        }

        public void LockFocus()
        {
            this.Enabled = false;
        }

        public void UnLockFocus()
        {
            this.Enabled = true;
        }

        public void SetControler(AbstractControler controler)
        {
            this.tb.TextChanged += new EventHandler(controler.ActionEvent);
            this.MouseDown += new MouseEventHandler(controler.ActionMouseDown);
            this.MouseUp += new MouseEventHandler(controler.ActionMouseUp);
            this.MouseMove += new MouseEventHandler(controler.ActionMouseMove);
        }

        public bool Correspond(PostIt p)
        {
            return p.GetID() == this.idModel;
        }

        public int GetID()
        {
            return this.idModel;
        }
    }
}
