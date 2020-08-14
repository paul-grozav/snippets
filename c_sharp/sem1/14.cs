using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Tablou
    {
        static public void Tipar(params int[] x)
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
            Tablou.Tipar(2, 4, 6, 8);//acum pot tiparii elementele fara sa mai fac o variabila de tip Tablou
            Console.ReadLine();
        }
    }
}