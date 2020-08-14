using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max, min;
            Console.Write("numarul de elemente ale vectorului=");
            n = int.Parse(Console.ReadLine());//citim cate elemente are vectorul
            int[] a = new int[n];//cream un vector cu atatea elemente cat s-a zis

            //citim elementele vectorului
            for (i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }

            //initial si max si min sunt primul element a[0]
            max = a[0];
            min = a[0];
            for (i = 1; i < n; i++)
            {
                if (a[i] < min) min = a[i];//daca elementul curent e mai mic decat minimul ... el e minimul
                if (a[i] > max) max = a[i];//daca elementul curent e mai mare decat maximul ... el e maximul
            }
            Console.Write("max=" + max + "\nmin=" + min);
            Console.ReadLine();
        }
    }
}