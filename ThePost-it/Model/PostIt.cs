using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    public class PostIt : ICloneable
    {
        private static int counter = 0;

        private static readonly object mutex = new object();

        private int x;
        private int y;
        private int id;

        private string text;

        private bool selected;

        public PostIt(int x, int y, string text)
        {
            this.id = BuildID();
            this.x = x;
            this.y = y;
            this.text = text;
            this.selected = false;
        }

        private PostIt() : this(0, 0, "")
        {

        }

        public PostIt(int x, int y) : this(x, y, "")
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

        public int BuildID()
        {
            int value;

            lock (mutex)
            {
                value = counter++;
            }

            return value;
        }

        public int GetID()
        {
            return id;
        }

        public override string ToString()
        {

            string s = "Post-it :\n";
            s += "X=" + this.x + "\n";
            s += "Y=" + this.y + "\n";
            s += "Text=" + this.text + "\n";

            return s;
        }

        public bool IsSelected()
        {
            return selected;
        }

        public void SetSelect(bool b)
        {
            selected = b;
        }


        public void Translate(int dx, int dy)
        {
            x += (x + dx >= 0) ? dx : 0;
            y += (y + dy >= 0) ? dy : 0;
        }

        public override bool Equals(object obj)
        {
            PostIt p = obj as PostIt;

            return x == p.x && y == p.y && text == p.text && id == p.id;
        }

        public object Clone()
        {
            PostIt p = new PostIt();

            p.id = id;
            p.text = text;
            p.x = x;
            p.y = y;
            p.selected = false;

            return p;
        }
    }
}
