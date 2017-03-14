using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class KontaBankowe
    {
        string imienazwisko { get; private set; }
        int nrkonta { get; private set; }
        double fundusze { get; private set; }
        int identyfikator { get; private set; }
        bool czydousuniecia {get;private set;}

        public KontaBankowe(string imie,int konto,double kasa,int id,bool usuniecie=false)
        {
            imienazwisko = imie;
            nrkonta = konto;
            fundusze = kasa;
            identyfikator = id;
        }
        public void wplac(double wplata)
        {
            fundusze += wplata;
        }
        public void zmienfunduszekonta(double zmiana)
        {
            fundusze=zmiana;
        }
       
        public void wyplacfundusze(double ilewyplacic)
        {
            fundusze =fundusze-ilewyplacic;
        }

        public void nalicz_odsetki(double odsetki)
        {
            fundusze = fundusze + fundusze * odsetki;
        }

        public void usuwanie(string decyzja)
        {
            if (decyzja == "do usuniecia")
            czydousuniecia = true;
        }

    }
}
