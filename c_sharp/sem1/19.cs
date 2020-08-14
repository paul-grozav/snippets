using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        //suma cifrelor
        static int sumaCifrelor(int n)
        {
            int s = 0;
            while (n != 0)
            {
                s += n % 10;
                n = n / 10;
            }
            return s;
        }

        //cea mai mare cifra a numarului
        static int ceaMaiMareCifra(int n)
        {
            int cifra = n % 10;
            while (n != 0)
            {
                if (cifra < n % 10) cifra = n % 10;
                n /= 10;
            }

            return cifra;
        }

        //oglinditul numarului
        static int inversul(int n)
        {
            int inv = 0;
            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }
            return inv;
        }

        //daca e prim sau nu
        static bool prim(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }

        //toate numerele prime <= n care citite invers sunt tot numere prime
        static void tnp(int n)
        {
            for (int i = 2; i <= n; i++)
                if (prim(i) && prim(inversul(i)))
                    Console.Write(i + " ");
        }



        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("suma cifrelor este " + sumaCifrelor(n));
            Console.WriteLine("cifra cea mai mare este = " + ceaMaiMareCifra(n));
            Console.Write("Inversul lui " + n + " este " + inversul(n) + "\n");
            tnp(n);

            Console.ReadLine();
        }
    }
}