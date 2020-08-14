using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    struct Punct
    {
        private double x;
        private double y;

        public Punct(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Punct p1 = new Punct(2.3, 3.5);
            Console.Write("x=" + p1.X + " y=" + p1.Y);
            Console.ReadLine();
        }
    }
}