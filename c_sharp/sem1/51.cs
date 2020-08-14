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

            if (s1.Equals(s2))
                Console.Write(s1 + " = " + s2);
            else
                Console.Write(s1 + " diferit de " + s2);

            Console.ReadLine();
        }
    }
}