﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static int[] st = new int[10];
        private static int i, k, n;

        private static void init(int k)
        {
            st[k] = 9;
        }

        private static bool succesor(int k)
        {
            if (st[k] == 0) return false;
            if (st[k] == 9)
            {
                st[k] = 8;
                return true;
            }
            else
            {
                st[k] -= 2;
                return true;
            }
        }

        private static bool valid(int k)
        {
            if (k==1) return true;
            return st[k] < st[k-1];//descrescatoare ... nu a zis strict descrescatoare...deci defapt aici trebuia <=
        }

        private static bool solutie(int k)
        {
            return k == n;
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