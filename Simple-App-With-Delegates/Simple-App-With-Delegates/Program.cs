using System;

namespace Simple_App_With_Delegates
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

                Console.WriteLine("Pierwsza Funkcja Show");
                kont.Show(callBack1);

                Console.WriteLine("Druga Funkcja Show");
                kont.Show(callBack2);

                Console.WriteLine("Trzecia Funkcja Show");
                kont.Show(callBack3);
            }
        }
    }

