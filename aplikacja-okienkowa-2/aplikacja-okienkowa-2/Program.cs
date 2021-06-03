using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja_okienkowa_2
{
    public class Program
    {
        public static void Show1(Kontener k) 
        {
            Console.WriteLine($"x = {k.x}");
            Console.WriteLine($"y = {k.y}\n");
        }

        public static void Show2(Kontener k) 
        {
            Console.WriteLine($"Wartość x = {k.x}");
            Console.WriteLine($"Wartość y = {k.y}\n");
        }

        public static void Show3(Kontener k) 
        {
            Console.WriteLine("Punkt składa sie z ");
            Console.WriteLine($"Punktu x = {k.x}");
            Console.WriteLine($"Puntku y = {k.y}\n");
        }

        [STAThread]
        static void Main()
        {
            Kontener kont = new Kontener(100, 200);
            Kontener.ShowCallBack callBack1 = new Kontener.ShowCallBack(Program.Show1);
            Kontener.ShowCallBack callBack2 = new Kontener.ShowCallBack(Program.Show2);
            Kontener.ShowCallBack callBack3 = new Kontener.ShowCallBack(Program.Show3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Pierwsza Funkcja Show");
            kont.Show(callBack1);

            Console.WriteLine("Druga Funkcja Show");
            kont.Show(callBack2);

            Console.WriteLine("Trzecia Funkcja Show");
            kont.Show(callBack3);
            // Application.Run(new Kontener());
        }
    }
}
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