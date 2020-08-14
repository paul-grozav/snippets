using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication31
{
    class Intreg
    {
        private int n;
        public Intreg(int i)
        {
            n = i;
        }
        public static Intreg operator ++(Intreg x)
        {
            return new Intreg(++x.n);
        }
        public static Intreg operator -(Intreg x)
        {
            return new Intreg(-x.n);
        }
        public override string ToString()
        {
            String s = string.Format("{0}", n);
            return s;
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            Intreg x = new Intreg(10);
            x++;
            Console.WriteLine(x + " " + -x);
            Console.ReadLine();
        }
    }
}