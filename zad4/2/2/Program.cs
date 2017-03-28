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
            ZwyklyTelefon stary = new ZwyklyTelefon("cegla");
            ZwyklyTelefon nowy = new ZwyklyTelefon("cegielka");
            Smartphone htc = new Smartphone(nowy, "nowoczesny");

            stary.WyslijWiadomosc("2113123123", "trybi");
            htc.zdjecie();

            Console.ReadLine();
        }
    }
}
