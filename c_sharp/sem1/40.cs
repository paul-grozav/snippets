using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _18.Oglinditul_unui_numar
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            ArrayList a = new ArrayList();
            do
            {
                Console.Write("Numarul este = ");
                n = int.Parse(Console.ReadLine());
            }while (n < 0 || n > 99999999);
            if (n == 0) a.Add(n);
            while (n > 0)
            {
                a.Add(n % 10);
                n = n / 10;
            }
            foreach (long y in a)
                Console.Write(y);
            Console.ReadLine();
        }
    }
}