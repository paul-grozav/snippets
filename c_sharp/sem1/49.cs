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
            String s = "Sandru,UAV,Arad";//fie acesta stringul
            char[] c = new char[] { ',' };//si acestia delimitatorii
            String[] ss = s.Split(c);//facem impartirea

            //afisarea bucatilor
            foreach (String a in ss) Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}