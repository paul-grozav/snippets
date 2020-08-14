using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static int[] st = new int[11];
        private static int i, k, s;
  
        static int sumaCifrelor()
        {
            int suma = 0;
            for (i = 1; i <= k; i++) suma += st[i];
            return suma;
        }

        private static void init(int k)
        {
            st[k] = -1;
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
            if ((k == 1) && (st[k] == 0)) return false;
            for (i = 1; i < k; i++) if (st[i] == st[k]) return false;
            return true;
        }

        private static bool solutie(int k)
        {
            return sumaCifrelor()>=s;
        }

        private static void tipar()
        {
            if (sumaCifrelor() != s) return;
            bool contineZero = false;
            for (i = 1; i <= k; i++)
            {
                Console.Write(st[i]);
                if (st[i] == 0) contineZero = true;
            }
            if (!contineZero)//daca nu contine niciun zero atunci mai adauga odata numarul cu 0 la capat
            {
                Console.WriteLine();
                for (i = 1; i <= k; i++)
                    Console.Write(st[i]);
                Console.Write(0);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool asr, ev = false;
            Console.Write("suma cifrelor(maxim 45)="); s = int.Parse(Console.ReadLine());

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