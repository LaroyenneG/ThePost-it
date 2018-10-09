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
        TextBox tb;

        private const int MARGIN_SIZE = 5;
        private static Color DEFAULT_COLOR = Color.Yellow;
        private static Size POST_SIZE = new Size(200, 200);

        private Post_it model;

        public DesignPost_It(Post_it model)
        {

            InitializeComponent();

            this.model = model;
            this.tb.TextChanged += new EventHandler(ActionTextChanged);
            this.Controls.Add(tb);

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
            SetColor(DEFAULT_COLOR);
            this.tb.Multiline = true;
            this.tb.Location = new Point(MARGIN_SIZE, MARGIN_SIZE);
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

        public Color GetColor()
        {
            return this.tb.BackColor;
        }


        public void ActionTextChanged(object sender, EventArgs e)
        {
            this.model.SetText(this.tb.Text);
            Console.WriteLine(this.model);
        }
    }
}
