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
            String s, s1;
            Console.Write("Cuvant=");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                s1 = s.Remove(i, 1);
                Console.WriteLine(s1);
            }
            Console.ReadLine();
        }
    }
}