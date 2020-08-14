using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static int[] st = new int[100];
        private static int[] vi = new int[100];
        private static int i, k, n, nrCifreM;

        private static void init()
        {
            if (k <= n) st[k] = 0;
        }

        private static bool succesor()
        {
            if (st[k] == nrCifreM) return false;
            else
            {
                st[k]++;
                return true;
            }
        }

        private static bool valid()
        {
            return true;
        }

        private static bool solutie()
        {
            return k == n;
        }

        private static void tipar()
        {
            for (i = 1; i <= k; i++)
            {
                Console.Write(vi[st[i]]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool asr, ev = false;
            int m;
            Console.Write("m="); m = int.Parse(Console.ReadLine());

            //pun fiecare cifra a lui m in vectorul vi si numar cifrele
            nrCifreM=0;
            while(m>0){
                nrCifreM++;
                vi[nrCifreM] = m % 10;
                m /= 10;
            }

            for (n = 1; n <= nrCifreM; n++)
            {
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
            }
            Console.ReadLine();
        }
    }
}