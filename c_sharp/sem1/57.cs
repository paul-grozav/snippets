using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main()
        {
            String c;
            int i;
            Console.Write("Cuvant=");
            c = Console.ReadLine();
            Console.WriteLine("Sufixele cuvantului " + c + " sunt:");
            for (i = 1; i <= c.Length; i++)
            {
                String s1 = c.Substring(0, i);
                Console.WriteLine(s1);
            }
            Console.ReadLine();
        }
    }
}