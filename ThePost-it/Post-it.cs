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


        public Post_it()
        {
            x = 0;
            y = 0;
            text = "";
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
    }
}
