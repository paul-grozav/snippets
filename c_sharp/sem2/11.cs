using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static int[] st = new int[10];
        private static int i, k, n, m;

        private static int nrDeCifre0()
        {
            int nrDeCifre0 = 0;
            for (i = 1; i <= k; i++) if (st[i] == 0) nrDeCifre0++;
            return nrDeCifre0;
        }

        private static void init(int k)
        {
            if (k <= n) st[k] = -1;
        }

        private static bool succesor(int k)
        {
            if (st[k] == 1) return false;
            else
            {
                st[k]++;
                return true;
            }
        }

        private static bool valid(int k)
        {
            if (k > n) return false;
            return nrDeCifre0() <= m;
        }

        private static bool solutie(int k)
        {
            return ((k == n) && (nrDeCifre0() == m));
        }

        private static void tipar()
        {
            for (i = 1; i <= n; i++)
            {
                Console.Write(st[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool asr, ev = false;
            Console.Write("numarul de cifre ="); n = int.Parse(Console.ReadLine());
            Console.Write("numarul de cifre de 0 ="); m = int.Parse(Console.ReadLine());

            k = 1;
            init(k);
            while (k > 0)
            {
                do
                {
                    asr = succesor(k);
                    if (asr) ev = valid(k);
                } while (asr && !ev);
                if (asr)
                    if (solutie(k)) tipar();
                    else
                    {
                        k++;
                        init(k);
                    }
                else k--;
            }
            Console.ReadLine();
        }
    }
}