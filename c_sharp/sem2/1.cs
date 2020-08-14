using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static int[,] a = new int[100,100];
        private static int i, j, k, n;

        private static void init()
        {
            for (i = 1; i <= n; i++) a[i, k] = 0;
        }

        private static bool succesor()
        {
            for (i = 1; i <=n; i++) if (a[i, k] == 1) break;
            if (i < n)
            {
                //il mut pe 1 cu o linie mai in jos pe acceasi coloana
                a[i, k] = 0;
                a[i + 1, k] = 1;
                return true;
            }
            else if (i == n) return false;
            else
            {
                a[1, k] = 1;
                return true;
            }
        }

        private static bool valid()
        {
            for (i = 1; i < n; i++) if (a[i, k] == 1) break;
            int ElementeDe1Gasite = 0;
            for (j = 1; j < k; j++) if (a[i, j] == 1) ElementeDe1Gasite++;
            return ElementeDe1Gasite==0;
        }

        private static bool solutie()
        {
            return k == n;
        }

        private static void tipar()
        {
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                    Console.Write(a[i,j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool asr, ev = false;
            Console.Write("n="); n = int.Parse(Console.ReadLine());

            k = 1;
            init();
            while (k > 0)
            {
                do
                {
                    asr = succesor();
                    if (asr) ev = valid();
                } while (asr && !ev);
                if (asr)
                    if (solutie()) tipar();
                    else
                    {
                        k++;
                        init();
                    }
                else k--;
            }
            Console.ReadLine();
        }
    }
}
