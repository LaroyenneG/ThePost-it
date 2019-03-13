using System.Drawing;
using System.Windows.Forms;

namespace ThePost_it
{
    public class DesignPostIt : Panel
    {
        private const int MARGIN_SIZE = 15;
        private static readonly Color DEFAULT_COLOR = Color.Yellow;
        private static readonly Size POST_SIZE = new Size(300, 300);
        private readonly int idModel;

        private TextBox tb;

        public DesignPostIt(PostIt p)
        {
            idModel = p.GetID();
            InitializeComponent();
            Controls.Add(tb);
            Display(p);
            Enabled = true;
        }


        private void InitializeComponent()
        {
            Size = POST_SIZE;
            MaximumSize = POST_SIZE;
            MaximumSize = POST_SIZE;
            MinimumSize = POST_SIZE;
            tb = new TextBox();
            tb.Size = new Size(POST_SIZE.Width - MARGIN_SIZE * 2, POST_SIZE.Height - MARGIN_SIZE * 2);
            tb.BorderStyle = BorderStyle.None;
            BorderStyle = BorderStyle.None;
            SetColor(DEFAULT_COLOR);
            tb.Multiline = true;
            tb.Location = new Point(MARGIN_SIZE, MARGIN_SIZE);
        }

        public void Display(PostIt postIt)
        {
            if (postIt.GetText() != tb.Text) tb.Text = postIt.GetText();

            Location = new Point(postIt.GetX(), postIt.GetY());

            if (postIt.IsSelected())
                Selected();
            else
                Deseleted();
        }

        private void SetColor(Color color)
        {
            BackColor = color;
            tb.BackColor = color;
        }

        public void Selected()
        {
            BackColor = Color.Gold;
        }

        public void Deseleted()
        {
            BackColor = DEFAULT_COLOR;
        }

        public void SetControler(AbstractControler controler)
        {
            tb.TextChanged += controler.ActionEvent;
            MouseDown += controler.ActionMouseDown;
            MouseUp += controler.ActionMouseUp;
            MouseMove += controler.ActionMouseMove;
        }

        public bool Correspond(PostIt p)
        {
            return p.GetID() == idModel;
        }

        public int GetID()
        {
            return idModel;
        }
    }
}