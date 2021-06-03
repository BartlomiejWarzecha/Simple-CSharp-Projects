using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja_okienkowa_2
{
    public class Program
    {
        public static void Show(Kontener k) 
        {
            Console.WriteLine($"x = {k.x}");
            Console.WriteLine($"y = {k.y}");
        }

        [STAThread]
        static void Main()
        {
            Kontener kont = new Kontener(100, 200);
            Kontener.ShowCallBack callBack = new Kontener.ShowCallBack(Program.Show);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Kontener());
        }
    }
}
