using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class A
    {
        public class B
        {
            public void F()
            {
                Console.Write("sunt in functia F()");
            }
        }
    }
    class Test
    {
        static void Main()
        {
            A.B obj = new A.B();
            obj.F();
            Console.ReadLine();
        }
    }
}