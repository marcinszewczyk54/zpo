using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<standardowyczlowiek> ludzie = new List<standardowyczlowiek>();
            double srednia=0.0;
            int zmienna=0;
            int tmp=0;
            int tmp1 = 0;

            ludzie.Add(new standardowyczlowiek("jan",22,"warszawa"));
            ludzie.Add(new standardowyczlowiek("dominik",99,"elk"));
            ludzie.Add(new standardowyczlowiek("zofia", 10, "elk"));
            foreach (var item in ludzie)
            {
               zmienna = zmienna + item.wiek;

            }
           
            srednia = Convert.ToDouble(zmienna / ludzie.Count);
            Console.WriteLine(srednia);
            Dictionary<string, int> miasta = new Dictionary<string, int>();

            foreach (var item in ludzie)
            {
                if(miasta.ContainsKey(item.miejscepochodzenia))
                {
                    miasta[item.miejscepochodzenia]++;
                }
                else
                {
                    miasta.Add(item.miejscepochodzenia, 0);
                }

                
            }
            Console.WriteLine("imiona");
            foreach (var item in ludzie)
            {
                Console.WriteLine(item.imie);
            }
            string najczestsze = miasta.OrderByDescending(x => x.Value).First().Key;

            Console.WriteLine("najczesciej wystepujace miasto {0}", najczestsze);
            
            Console.ReadKey();
        }

    }
}
