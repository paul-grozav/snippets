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
            String s0 = "azi e luni";
            String s = " nu";
            string s1 = s0.Insert(3, s);//pune pe s in s0 la pozitia 3. In String numerotarea pozitilor caracterelor incepe de la 0
            Console.Write(s1);
            Console.ReadLine();
        }
    }
}