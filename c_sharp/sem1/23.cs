using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    partial class A
    {
        public void F()
        {
            Console.WriteLine("F");
        }
    }

    partial class A
    {
        public void G()
        {
            Console.WriteLine("G");
        }
    }

    class Test
    {
        static void Main()
        {
            A a = new A();
            a.F();
            a.G();
            Console.ReadLine();
        }
    }
}