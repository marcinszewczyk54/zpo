using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class standardowyczlowiek
    {
        public string imie { get; private set; }
       public  int wiek { get; private set; }
        public static int ilosckosciszkieletowych =123;
        public string miejscepochodzenia {get; private set;}
        public static int iloscchromosomow =206;

        public standardowyczlowiek(string Imie,int Wiek, string MiejscePochodzenia)
        {
            imie = Imie;
            wiek = Wiek;
            miejscepochodzenia = MiejscePochodzenia;
        }
    }
}
