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

            //dupa fiecare element de pe pozitile impare P adaug un numar de P elemente avand ca si continut valoarea elementului de pe pozitia P
            for(i=1; i<=n; i++)
            {
                b.Add(a[i - 1]);
                if (i % 2 != 0)//daca pozitia e impara
                    for (j = 1; j <= i; j++)//de P=i ori ...
                        b.Add(a[i - 1]);//adaug elementul de la pozitia i
            }

            Console.Write("Lista obtinuta este :");
            foreach (float y in b) Console.Write(" "+y);

            Console.ReadLine();
        }
    }
}