using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static float[] vi = new float[100];
        static int[] st = new int[100];
        static int i, n, k;
        static float min = float.MaxValue;
        static float max = float.MinValue;
        static int PMin, PMax;

        static void init()
        {
            st[k] = 0;
        }

        static bool succesor()
        {
            if (st[k] + 1 != PMin)
            {
                if (st[k] + 1 != PMax)
                {
                    if (st[k] + 1 < n)
                    {
                        st[k]++;
                        return true;
                    }
                    else return false;
                }
                else
                {
                    if (st[k] + 2 != PMin)
                    {
                        if (st[k] + 2 < n)
                        {
                            st[k] += 2;
                            return true;
                        }
                        else return false;
                    }
                    else
                    {
                        if (st[k] + 3 < n)
                        {
                            st[k] += 3;
                            return true;
                        }
                        else return false;
                    }
                }
            }
            else
            {
                if (st[k] + 2 != PMax)
                {
                    if (st[k] + 2 < n)
                    {
                        st[k] += 2;
                        return true;
                    }
                    else return false;
                }
                else
                {
                    if (st[k] + 3 < n)
                    {
                        st[k] += 3;
                        return true;
                    }
                    else return false;
                }
            }
        }

        static bool valid()
        {
            for (i = 1; i < k; i++) if (st[i] == st[k]) return false;
            return true;
        }

        static bool solutie()
        {
            return (k == n - 2);
        }

        static void tipar()
        {
            int j = 1;
            i = 1;
            while(i<=n)
            {
                if ((i == PMin) || (i == PMax))
                {
                    Console.Write(vi[i] + " ");
                }
                else
                {
                    Console.Write(vi[st[j]] + " ");
                    j++;
                }
                i++;
            }

//            for (i = 1; i <= k; i++) Console.Write(vi[st[i]] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool asr, ev = false;

            do{
                Console.Write("Numarul de numere (>2):");
                n = int.Parse(Console.ReadLine());
            } while (n <= 2);

            for (i = 1; i <= n; i++)
            {
                //Daca o luam ca la Analiza Matematica multimea {1, 1, 5, 9, 16} nu are cel mai mic element
                //Treaba ta daca dai 2 elemente identice
                Console.Write("Numarul "+i+" este:");
                vi[i] = float.Parse(Console.ReadLine());
            }

            //aflarea minimului si a maximului si a pozitilor lor
            for (i = 1; i <= n; i++)
            {
                if (vi[i] < min) { min = vi[i]; PMin = i; }
                if (vi[i] > max) { max = vi[i]; PMax = i; }
            }
            //Acum stiim ca la pozitia PMin in vectorul vi se afla elementul cel mai mic si la pozitia PMax se afla cel mai mare element
            //cream vectorul st cu elementele lui vi care nu sunt min si max
//            k = 0;//cate elemente am in st
//            for (i = 1; i <= n; i++)
//            {
//                if ((i != PMin) && (i != PMax))
//                {
//                    k++;
//                    st[k] = vi[i];
//                }
//            }

            //voi genera toate permutarile pentru restul numerelor (in afara de min si max)
            //in st voi tine pozitia elementului din vi
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
                {
                    if (solutie()) tipar();
                    else
                    {
                        k++;
                        init();
                    }
                }
                else k--;
            }
            Console.ReadLine();
        }
    }
}
