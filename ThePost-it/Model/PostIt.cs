using System;

namespace ThePost_it
{
    public class PostIt : ICloneable
    {
        private static int counter;

        private static readonly object mutex = new object();
        private int id;
        private bool selected;
        private string text;

        private int x;
        private int y;

        public PostIt(int x, int y, string text)
        {
            id = BuildID();
            this.x = x;
            this.y = y;
            this.text = text;
            selected = false;
        }

        private PostIt() : this(0, 0, "")
        {
        }

        public PostIt(int x, int y) : this(x, y, "")
        {
        }

        public object Clone()
        {
            var p = new PostIt();

            p.id = id;
            p.text = text;
            p.x = x;
            p.y = y;
            p.selected = false;

            return p;
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
            return x;
        }

        public int GetY()
        {
            return y;
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
            x += x + dx >= 0 ? dx : 0;
            y += y + dy >= 0 ? dy : 0;
        }


        public override string ToString()
        {
            var s = "Post-it :\n";
            s += "X=" + x + "\n";
            s += "Y=" + y + "\n";
            s += "Text=" + text + "\n";

            return s;
        }
    }
}