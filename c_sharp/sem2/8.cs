using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static int[] st = new int[10];
        private static int i, k, n, p, c;

        private static int nrDeCifreC(){
            int nrDeCifreC = 0;
            for (i = 1; i <= k; i++) if (st[i] == c) nrDeCifreC++;
            return nrDeCifreC;
        }

        private static void init(int k)
        {
            if(k<=n) st[k] = -1;
        }

        private static bool succesor(int k)
        {
            if (st[k] == 9) return false;
            else
            {
                st[k]++;
                return true;
            }
        }

        private static bool valid(int k)
        {
            if (k > n) return false;
            return nrDeCifreC()<=p;
        }

        private static bool solutie(int k)
        {
            return ((k == n) && (nrDeCifreC()==p));
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
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            Console.Write("p="); p = int.Parse(Console.ReadLine());
            Console.Write("c="); c = int.Parse(Console.ReadLine());

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