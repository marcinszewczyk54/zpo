using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            astonmartin pierwszy = new astonmartin();
            rangerover drugi = new rangerover();
            rollsroyce trzeci = new rollsroyce();
            wypisz(pierwszy);
            wypisz(drugi);
            wypisz(trzeci);
        }
        static void wypisz(Isamochod samochody)
        {
            Console.WriteLine(samochody.wypiszmarke() +  samochody.wypiszsalon());
        }
    }
}
