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
            int n, i, j;
            float s;
            ArrayList a = new ArrayList();
 
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

            //elimin 1 sau 2 elemente din mijlocul listei (in functie daca are un nr par de elemente sau impar)
            if (n % 2 == 0){//daca e par elimin 2 elemente
                a.RemoveAt(n / 2 - 1);
                a.RemoveAt(n / 2 - 1);
            }
            else
            {
                a.RemoveAt((n+1)/2 - 1);
            }

            Console.Write("Lista obtinuta este :");
            foreach (float y in a) Console.Write(" "+y);

            Console.ReadLine();
        }
    }
}