using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            samochod opel = new samochod("opel", 4, 0.0, "srebrny", 1999);
            samochod cbr=new samochod("audi",4,0.0,"czarny");
            samochod inny = new samochod("seat", 3, 30.0);
            opel.Jedz(150.0);
            cbr.Jedz(100.0);
            inny.Jedz(30.0);
            opel.hamuj();
            
            List<samochod> samochody = new List<samochod>();
            samochody.Add(new samochod("fiat", 4, 123.0, "niebieski"));
            samochody.Add(new samochod("honda", 2, 111.0));

            foreach (var item in samochody)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
