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
            String s1 = "Luni";
            String s2 = "luni";

            int comp = String.Compare(s1, s2);
            switch (comp)
            {
                case 0: Console.Write(s1 + " = " + s2); break;
                case 1: Console.Write(s1 + " > " + s2); break;
                case 2: Console.Write(s1 + " < " + s2); break;
            }

            Console.ReadLine();
        }
    }
}