using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePost_it
{
    class DesignPost_It : Panel
    {

        private Point mousePosition;

        private TextBox tb;

        private const int MARGIN_SIZE = 15;
        private static Size POST_SIZE = new Size(200, 200);

        private Post_it model;

        public DesignPost_It(Post_it model)
        {

            InitializeComponent();

            mousePosition = new Point(0, 0);

            this.model = model;
            this.tb.TextChanged += new EventHandler(ActionTextChanged);
            this.MouseDown += new MouseEventHandler(ActionMouseDown);
            this.MouseUp += new MouseEventHandler(ActionMouseUp);
            this.MouseMove += new MouseEventHandler(ActionMouseMove);
            this.Controls.Add(tb);

            SetColor(this.model.GetColor());

            Display();
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
            this.tb.Multiline = true;
            this.tb.Location = new Point(MARGIN_SIZE, MARGIN_SIZE);
            LockFocus();
        }

        public void Display()
        {
            this.tb.Text = this.model.GetText();
            this.Location = new Point(this.model.GetX(), this.model.GetY());
        }

        public void SetColor(Color color)
        {
            this.BackColor = color;
            this.tb.BackColor = color;
        }


        public void ActionMouseMove(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X, this.Location.Y + e.Y);
            }

            mousePosition = e.Location;
        }

        public void ActionMouseUp(Object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) != Keys.Shift)
            {
                Deseleted();
            }
        }

        public void ActionMouseDown(Object sender, MouseEventArgs e)
        {
            Selected();
        }

        public void ActionTextChanged(object sender, EventArgs e)
        {
            this.model.SetText(this.tb.Text);
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
    }
}
