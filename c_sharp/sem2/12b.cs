using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        struct ps
        {
            public int produs, suma;
        }

        static int[] v = new int[100];

        static ps sumaSiProdusul(int s, int d)
        {
            if (d == s){
                ps a = new ps();
                a.produs = a.suma = v[s];
                return a;
            }
            else if (d - s == 1)
            {
                ps a = new ps();
                a.suma = v[s] + v[d];
                a.produs = v[s] * v[d];
                return a;
            }
            else
            {
                ps rs = sumaSiProdusul(s, (s + d) / 2);
                ps rd = sumaSiProdusul((s + d) / 2 + 1, d);

                ps a = new ps();
                a.suma = rs.suma+rd.suma;
                a.produs = rs.produs*rd.produs;
                return a;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("numarul de numere="); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("v[" + i + "]=");
                v[i] = int.Parse(Console.ReadLine());
            }

            ps r = sumaSiProdusul(1, n);
            Console.Write("suma="+r.suma+"\nprodusul="+r.produs);
            Console.ReadLine();
        }
    }
}