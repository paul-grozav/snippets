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

            //elimin elementele Xi pentru care suma elementelor de la X1 la X(i-1) e egala cu Xi
            for(i=1; i<=a.Count; i++)
            {
                s = 0;
                for (j = 1; j < i; j++) s += (float)a[j - 1];

                Console.WriteLine("i="+i);
                if (s == (float)a[i-1]) a.RemoveAt(i - 1);
            }

            //elimin elementele negative
            for (i = 1; i <= a.Count; i++)
                if ((float)a[i - 1] < 0) a.RemoveAt(i - 1);

            Console.Write("Lista obtinuta este :");
            foreach (float y in a) Console.Write(" "+y);

            Console.ReadLine();
        }
    }
}