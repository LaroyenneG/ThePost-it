using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePost_it
{
    class Post_it
    {

        private int x;
        private int y;

        private string text;

        public Post_it(int x, int y, string text)
        {
            this.x = x;
            this.y = y;
            this.text = text;
        }

        public Post_it() : this(0, 0, "")
        {
         
        }

        public Post_it(int x, int y) : this(x, y, "")
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

            return s;
        }
    }
}
