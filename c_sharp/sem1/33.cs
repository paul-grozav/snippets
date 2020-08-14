using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Baza
    {
        public Baza()
        {
            Console.WriteLine("constructorul clasei Baza");
        }
    }

    class Derivat : Baza
    {
        public Derivat()
        {
            Console.WriteLine("constructorul clasei Derivat");
        }
    }

    class Test
    {
        static void Main()
        {
            Derivat d = new Derivat();//constructorul clasei Derivat apeleaza implicit constructorul clasei Baza
            Console.ReadLine();
        }
    }
}