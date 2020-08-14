using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Baza
    {
        public int x;
        public Baza(int y)
        {
            x = y;
        }
    }

    class Derivat : Baza
    {
        public char c;
        public Derivat(char a, int b):base(b)//base(b) e apelarea explicita a constructorului clasei de baza
        {
            c = a;
        }
    }

    class Test
    {
        static void Main()
        {
            Derivat d = new Derivat('M', 13);
            Console.Write(d.c+" "+d.x);
            Console.ReadLine();
        }
    }
}