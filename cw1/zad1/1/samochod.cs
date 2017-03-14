using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class samochod
    {
       public string Marka { get;private set;}
       public int LiczbaKol { get; private set; }
       public double Predkosc { get; private set; }
       public string Kolor { get; private set; }
       public int Rocznik { get; private set; }

        public samochod(string marka,int liczbakol, double predkosc, string kolor="czarny",int rocznik=2016)
        {
            Marka =marka;
            LiczbaKol = liczbakol;
            Predkosc = predkosc;
            Kolor = kolor;
            Rocznik = rocznik;
        }

        public void Jedz(double predkosc)
        {
            Console.WriteLine("predkosc samochodu to {0}", predkosc);
        }
        public void hamuj()
        {
            Predkosc = 0.0;
        }

        public override string ToString()
        {
            return string.Format("{0} samochod marki {1} jedzie z predkoscia {2} \n domyslna liczba kol uzywana w samochodzie to {3}",
                Kolor,Marka,Predkosc,LiczbaKol);
        } 
    }
}
