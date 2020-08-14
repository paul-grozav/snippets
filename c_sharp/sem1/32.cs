using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    interface IPrintable
    {
        void Print(String s);
    }
    public class Mail : IPrintable
    {
        private string s;
        public Mail(string s)
        {
            this.s = s;
        }
        //implementarea metodei interfetei - obligatoriu
        public void Print(string a)
        {
            Console.WriteLine(s + a);//Aici se uneste "Astazi " cu "miercuri"
        }
    }
    class Test
    {
        static void Main()
        {
            Mail m = new Mail("Astazi ");
            m.Print("miercuri");
            Console.ReadLine();
        }
    }
}