using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];//aici tinem minte cifrele distincte
            int[] ap = new int[10];//aici tinem minte de cate ori apare fiecare cifra distincta
            int[] b = new int[10];//aici o sa construim numarul palindrom
            int i, k, n, m, s;

            //citim numarul de 8 cifre
            do
            {
                Console.Write("Dati un numar de 8 cifre :");
                n = int.Parse(Console.ReadLine());
            } while (n < 10000000 || n > 99999999);

            //umplem vectorul a cu cifrele distincte din numarul nostru n. Coborand cu for de la 9 la 0 in a vom pune cifrele descrescator
            k = 0;//nr de cifre in a
            for (i = 9; i > 0; i--)
            {
                m = n;//lucrez mai departe pe m si nu pe numarul original n
                s = 0;//aici numar de cate ori apare cifra i in numarul m
                while (m != 0)
                {
                    if (m % 10 == i)
                        s++;
                    m = m / 10;
                }
                if (s != 0)//daca am gasit-o
                {
                    a[k] = i;//in a pun cifra i
                    ap[k] = s;//si in ap pun de cate ori a aparut (de s ori)
                    k++;//si dimensiunea lui a creste cu o unitate
                }
            }

            //frecventa numerelor            
//            for (i = 0; i <= k; i++)
//                Console.Write(a[i] + " " + ap[i] + "\n");

            i = 0;
            while (i < (k-1) && ap[i] % 2 == 0)
                i++;
            if (ap[i] % 2 != 0)//daca una din cifre apare de un numar impar de ori
                Console.WriteLine("0");//afisez 0 deoarece nu pot forma un palindrom
            else
            {//daca pot forma palindrom
                s = 0;
                for (i = 0; i <= k; i++)//ma plimb prin cifrele distincte puse in ordine descrescatoare
                {
                    for (int l = 1; l <= ap[i] / 2; l++)//si fiecare cifra o pun de cate ori aparea/2 (pot imparti la 2 ca apare de un nr par de ori)
                    {
                        b[s] = a[i];//odata o pun la pozitia s
                        b[7 - s] = a[i];//si inca odata la 7-s ... pozitia 7 fiind ultima pozitie din numarul de 8 cifre palindrom
                        s++;
                    }
                }
                //afisam apoi numarul palindrom
                for (i = 0; i <= 7; i++)
                    Console.Write(b[i]);
            }
            Console.ReadLine();
        }
    }
}