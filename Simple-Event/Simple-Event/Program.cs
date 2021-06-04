using System;

namespace Simple_Event
{
    class Program
    {
            public static void OnUjemne(Kontener k) 
            {
                Console.WriteLine($"X jest ujemne = {k.GetX()}");
            }
            public static void OnDodatnie(Kontener k) 
            {
                Console.WriteLine($"X jest dodatnie = {k.GetX()}");
            }
        static void Main(string[] args)
        {
            Kontener kont = new Kontener();
            Kontener.XJestUjemne += new Kontener.EventHandler(OnUjemne);
            Kontener.XJestDodatnie += new Kontener.EventHandler(OnDodatnie);
            
            kont.SetX(2);
            kont.SetX(-2);
        }
    }
}
