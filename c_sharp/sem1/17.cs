using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, ne = 0, s = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int[] x = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("n[" + i + "]=");
                x[i] = int.Parse(Console.ReadLine());
            }

            float[] y = new float[n];

            for (i = 0; i < n; i++)
            {

                //numararea elementelor de pe pozitii <= si crearea sumei
                for (j = 0; j <= i; j++)
                {
                    if (x[j] > 0)
                    {
                        ne++;
                        s += x[j];
                    }
                }

                if (ne == 0)
                    y[i] = -1;
                else
                    y[i] = (float)s / ne;

                ne = s = 0;
            }

            Console.WriteLine();
            //afisarea lui y
            for (i = 0; i < n; i++)
                Console.WriteLine("y[" + i + "] = " + y[i]);

            Console.ReadLine();
        }
    }
}