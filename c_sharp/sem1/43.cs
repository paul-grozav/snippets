using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication24
{
    class Program
    {
        static ArrayList l = new ArrayList();
        static float x;

        static void creare()
        {
            int n, i;
            float c;
            Console.Write("Grad polinom=");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                Console.Write("coeficient grad " + i + " ");
                c = float.Parse(Console.ReadLine());
                l.Add(c);
            }
        }

        static float calcul()
        {
            float pol = 0, put = 1;
            foreach (float c in l)
            {
                pol += c * put;
                put *= x;
            }
            return pol;
        }

        static void Main()
        {
            creare();
            Console.Write("x=");
            x = float.Parse(Console.ReadLine());
            Console.Write("P(" + x + ")=" + calcul());
            Console.ReadLine();
        }
    }
}