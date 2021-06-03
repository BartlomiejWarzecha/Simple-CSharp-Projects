using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacja_okienkowa_2
{
    public class Kontener
    {
        public int x, y;
        public Kontener() { }
        public Kontener(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public delegate void ShowCallBack(Kontener k);

    }
}
