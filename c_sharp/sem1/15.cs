using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static int x = 10;
        static void F() { }
        int y = 20;
        void G() { }

        static void Main()
        {
            x = 100;
            F();
            Program.x = 100;
            Program.F();
            //Program.G();//nu merge
            Program p = new Program();
            p.y = 30;
            p.G();
        }
    }
}