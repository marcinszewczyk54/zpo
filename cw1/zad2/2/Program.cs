using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            KontaBankowe pierwsze = new KontaBankowe("Jan Nowak", 12312312, 37.14, 0);
            KontaBankowe drugie = new KontaBankowe("Egon Klawy", 21312, 1000000.1, 1);

            pierwsze.wplac(10);
            pierwsze.nalicz_odsetki(0.01);
            drugie.usuwanie("do usuniecia");
        }
    }
}
