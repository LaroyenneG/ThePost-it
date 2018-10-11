using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    class Post_it
    {

        private static Color DEFAULT_COLOR = Color.Yellow;

        private Color color;
        private bool selected;
        private int x;
        private int y;

        private string text;

        public Post_it(int x, int y, string text, Color color)
        {
            this.x = x;
            this.y = y;
            this.text = text;
            this.color = color;
            selected = false;
        }

        public Post_it() : this(0, 0, "", DEFAULT_COLOR)
        {
        
        }

        public Post_it(int x, int y) : this(x, y, "", DEFAULT_COLOR)
        {

        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return text;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public override string ToString()
        {
            string s = "Post-it :\n";
            s += "X=" + this.x + "\n";
            s += "Y=" + this.y + "\n";
            s += "Text=" + this.text + "\n";
            s += "Is selected" + this.selected + "\n";

            return s;
        }

        public bool IsSelected()
        {
            return selected;
        }

        public void setSelected(bool b)
        {
            this.selected = b;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public Color GetColor()
        {
            return this.color;
        }
    }
}
