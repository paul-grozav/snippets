using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication31
{
    public class Fractie
    {
        private int numarator;
        private int numitor;
        private static int Cmmdc(int a, int b)
        {
            if (b == 0) return a;
            return Cmmdc(b, a % b);
        }
        public Fractie(int numarator, int numitor)
        {
            int div = Cmmdc(numarator, numitor);
            numarator /= div;
            numitor /= div;
            this.numarator = numarator;
            this.numitor = numitor;
        }
        public Fractie()
        {
        }
        public static Fractie operator +(Fractie f1, Fractie f2)
        {
            int A = f1.numarator * f2.numitor + f2.numarator * f1.numitor;
            int B = f1.numitor * f2.numitor;
            int cmmdc = Cmmdc(A, B);
            A /= cmmdc;
            B /= cmmdc;
            return new Fractie(A, B);
        }
        public static bool operator ==(Fractie f1, Fractie f2)
        {
            if (f1.numitor == f2.numitor && f1.numarator == f2.numarator)
                return true;
            return false;
        }
        public static bool operator !=(Fractie f1, Fractie f2)
        {
            return !(f1 == f2);
        }
        public override string ToString()
        {
            string s = numarator.ToString() + "/" + numitor.ToString();
            return s;
        }
        public int Numarator
        {
            get
            {
                return numarator;
            }
            set
            {
                numarator = value;
            }
        }
        public int Numitor
        {
            get
            {
                return numitor;
            }
            set
            {
                numitor = value;
            }
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            //Fractie a = new Fractie(3, 4);
            Fractie a = new Fractie();
            Console.WriteLine("Dati fractia a scriind numaratorul ENTER numitorul");
            a.Numarator = int.Parse(Console.ReadLine());
            a.Numitor = int.Parse(Console.ReadLine());
            Console.WriteLine("a="+a.ToString());
            Fractie b = new Fractie(2, 4);
            Console.WriteLine("b="+b.ToString());
            Fractie c = a + b;
            Console.WriteLine("c=a+b="+c.ToString());
            Fractie d = new Fractie(8, 16);
            if (d == b)
                Console.WriteLine("d=b="+d);
            if (a != b)
                Console.WriteLine(a + " != " + b);
            a += b;
            Console.WriteLine("a=" + a);
            Console.ReadLine();
        }
    }
}