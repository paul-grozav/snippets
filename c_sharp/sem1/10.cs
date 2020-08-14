using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Test
    {
        private int x;
        
        public int GetX() { return x; }

        public void SetX(int v) { x = v; }
    }

    class Test1
    {
        static void Main()
        {
            Test r = new Test();
            r.SetX(10);
            //r.x = 10;//nu merge
            Console.Write(r.GetX());
            Console.ReadLine();
        }
    }
}