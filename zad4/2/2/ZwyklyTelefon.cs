using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class ZwyklyTelefon:ITelefon
    {
        private string Typ;

        public ZwyklyTelefon(string typ)
        {
            Typ = typ;
        }
        public void WybierzNumer(string numer)
        {
            Console.WriteLine("wybiera nr {0}",numer);
        }

        public void WyslijWiadomosc(string numer, string tresc)
        {
            Console.WriteLine("napisal: {0} do {1}",tresc,numer);
        }

        public void PokazTyp()
        {
            Console.WriteLine("telefon typu : {0}",Typ);
        }
    }
}
