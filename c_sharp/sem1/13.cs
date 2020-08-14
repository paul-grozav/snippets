using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Tablou
    {
        public void Tipar(params int[] x)
        {
            foreach (int i in x)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }

    class Test
    {
        static void Main()
        {
            Tablou t = new Tablou();
            t.Tipar(2, 4, 6, 8);//acesta este vectorul ... format cu elementele {2, 4, 6, 8}
            int[] a = { 5, 6 };
            t.Tipar(a);
            Console.ReadLine();
        }
    }
}