using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            //citirea vectorului
            for (i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }

            //stabilirea maximului
            max = a[0];
            for (i = 1; i < n; i++)
            {
                if (max < a[i]) max = a[i];
            }

            //aici folosesc un algoritm destul de incurcat pentru eliminarea elementului(elor) maxim(e)
            for (i = 0; i < n; i++)//ma plimb prin vector
                if (a[i] == max)//daca l-am gasit la pozitia i pe maxim
                    while (a[i] == max)//atat timp cat maximul e pe pozitia i
                    {
                        for (int j = i + 1; j < n; j++)//mergi de la i mai inainte
                            a[j - 1] = a[j];//si muta-le pe toate cu o pozitie inapoi (in ideea sa vina din dreapta altul peste maxim si sa dispara)
                        n--;//daca am facut asta inseamna ca am pierdut un element din vector => nr de elemente(n) scade cu o unitate
                        if (i == n && i!= 0) i--;//si daca i-ul era pe prima sau ultima pozitie (adica n-1 ca elementele sunt puse de la 0) atunci scad i-ul cu o unitate

                        if (n == 1 && a[i] == max)//daca mai am numai un element in vector si ala e maxim
                        {
                            n = 0;//in vector nu mai am niciun element
                            a = new int[n];//vectorul devine gol
                            break;//si nu mai caut
                        }
                    }


            Console.Write("Noul vector obtinut prin eliminarea elementelor maxime este :");
            //afisarea vectorului fara elementul maxim
            for (i = 0; i < n; i++) Console.Write(" "+a[i]);

            Console.ReadLine();

        }
    }
}