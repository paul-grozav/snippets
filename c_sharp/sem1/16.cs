using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Masina1
    {
        public string nume;
        public int pret;
    }

    class Masina2
    {
        public string nume;
        public int pret;

        public Masina2(string n, int p){//aici creez eu un constructor pentru masina
            nume = n;
            pret = p;
            //sau this.nume = n;
        }
    }

    class Test
    {
        static void Main()
        {
            Masina1 m1 = new Masina1();//creez o masina noua folosind constructorul care se creaza automat la orice clasa
            m1.nume = "Mihai";//apoi ii dau un nume
            m1.pret = 8;//apoi un pret

            Masina2 m2 = new Masina2("Mihai", 8);//aici obtin o masina cu aceleasi caracteristici/proprietati (acelasi nume si acelasi pret)
            //doar ca am trimis proprietatiile masinii atunci cand am creat masina ... si constructorul a creat-o asa cum i-am spus
        }
    }
}