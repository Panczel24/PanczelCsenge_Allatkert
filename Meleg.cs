using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatkertOOp
{
    internal class Meleg
    {
        int sebesseg;
        string nev;
        string nem;
        int eletkor;

        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Nem { get => nem; set => nem = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }

        public Meleg(int sebesseg, string nev, string nem, int eletkor)
        {
            Sebesseg = sebesseg;
            Nev = nev;
            Nem = nem;
            Eletkor = eletkor;
        }
    }
}
