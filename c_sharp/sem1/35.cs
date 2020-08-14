using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Baza
    {
        public int camp = 10;
        public void Metoda()
        {
            Console.WriteLine("Metoda clasei Baza");
        }
    }

    class Derivat : Baza
    {
        new public int camp = 20;
        new public void Metoda()
        {
            Console.WriteLine("Metoda clasei Derivat Baza.camp=base.camp="+base.camp+" Derivat.camp="+camp);
            base.Metoda();
        }
    }

    class Test
    {
        static void Main()
        {
            Derivat d = new Derivat();
            d.Metoda();
            Console.ReadLine();
        }
    }
}