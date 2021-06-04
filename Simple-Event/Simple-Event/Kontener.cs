using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Event
{
    class Kontener
    {
        private int? x;

        public Kontener() 
        {
            SetX(0);
        }

        public delegate void EventHandler(Kontener k);

        public static event EventHandler XJestUjemne;
        public static event EventHandler XJestDodatnie;

        public void SetX(int? x)
        { 
            this.x = x;
            if (x < 0) 
            {
                if (x != null)
                {
                    XJestUjemne(this);
                }
            }

            if (x > 0) 
            {
                if (x != null)
                {
                    XJestDodatnie(this);
                }
            }
        }
        public int? GetX()
        {
            return x;
        }
    }
}
