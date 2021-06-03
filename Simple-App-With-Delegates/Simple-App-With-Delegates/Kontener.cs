using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_App_With_Delegates
{
    public class Kontener
    {
        public int x, y;
        public Kontener(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public delegate void ShowCallBack(Kontener k);
        public void Show(ShowCallBack k)
        {
            k(this);
        }
    }
}
