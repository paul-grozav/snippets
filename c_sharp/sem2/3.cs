using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static int[] st = new int[100];
        private static int i, k, n;

        private static void init(int k)
        {
            st[k] = 0;
        }

        private static bool succesor(int k)
        {
            if (st[k] < 2*n-1)
            {
                if (st[k] != 0)
                    st[k] += 2;
                else
                    st[k] = 1;
                return true;
            }
            else return false;
        }

        private static bool valid(int k)
        {
            for (i = 1; i < k; i++) if (st[i] == st[k]) return false;

            return true;
        }

        private static bool solutie(int k)
        {
            return k == n;
        }

        private static void tipar()
        {
            for (i = 1; i <= n; i++)
            {
                Console.Write(st[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool asr, ev=false;
            Console.Write("n="); n = int.Parse(Console.ReadLine());


            k = 1;
            init(k);
            while (k > 0)
            {
                do
                {
                    asr = succesor(k);
//                    Console.Write("Coloana:" + k + ", si coloana are succesor?"+asr);
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
