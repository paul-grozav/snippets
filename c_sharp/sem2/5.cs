using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] felul1 = new String[5];
            String[] felul2 = new String[6];
            String[] felul3 = new String[4];
            int i, j, k;

            Console.WriteLine("Intr-un restaurant, un meniu este format din trei feluri de mancare. Exista patru preparate culinare: pentru felul unu, cinci preparate culinare pentru felul doi si trei preparate culinare pentru felul trei. Sa se genereze toate meniurile care se pot forma cu aceste preparate culinare.");

            Console.WriteLine("Introduceti preparatele culinare(4) pentru felul 1:");
            for (i = 1; i <= 4; i++)
            {
                Console.Write("Introduceti preparatul culinar " + i + ":");
                felul1[i] = Console.ReadLine();
            }

            Console.WriteLine("Introduceti preparatele culinare(5) pentru felul 2:");
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Introduceti preparatul culinar " + i + ":");
                felul2[i] = Console.ReadLine();
            }

            Console.WriteLine("Introduceti preparatele culinare(3) pentru felul 3:");
            for (i = 1; i <= 3; i++)
            {
                Console.Write("Introduceti preparatul culinar " + i + ":");
                felul3[i] = Console.ReadLine();
            }

            Console.WriteLine("cele 60 de combinatii posibile sunt:\n");

            for (i = 1; i <= 4; i++) for (j = 1; j <= 5; j++) for (k = 1; k <= 3; k++) Console.WriteLine(felul1[i] + ", " + felul2[j] + ", " + felul3[k]);

            Console.ReadLine();
        }
    }
}
