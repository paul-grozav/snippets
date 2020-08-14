using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication24
{
    class Program
    {
        static bool prim(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }

        static void Main()
        {
            int n, i;
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            //citim lista
            do
            {
                Console.Write("Cate elemente are lista?");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            for (i = 1; i <= n; i++)
            {
                Console.Write("a["+i+"]=");
                a.Add(float.Parse(Console.ReadLine()));
            }

            //eliminarea elementelor de pe pozitiile numere prime
            for (i = 1; i <= n; i++)
                if (!prim(i))
                    b.Add(a[i-1]);

            Console.Write("Lista obtinuta eliminand elementele de pe pozitiile numere prime este :");
            foreach (float y in b) Console.Write(" "+y);

            Console.ReadLine();
        }
    }
}