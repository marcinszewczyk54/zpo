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
            List<bohater> postacie = new List<bohater>();

            postacie.Add(new mag (50, 20.0, rasyenum.rasy.czlowiek, 100.0));
            postacie.Add(new wojownik(250, rasyenum.rasy.krasnolud,200.0));
            postacie.Add(new rzezimieszek(12.0,rasyenum.rasy.ork,150.0,180.0));

          
            
            int runda = 1;

            foreach (var postac in postacie)
                if (postac.sprawdzhp()=="zyje")
                    Console.WriteLine(postac);

            Console.WriteLine();

            do
            {
                Random r = new Random(DateTime.Now.Millisecond);
                Console.WriteLine("Runda: {0}\n", runda);

                if (r.NextDouble() > 0.5)
                    postacie[0].bijwroga(postacie[2]);
                else
                    ((mag)postacie[0]).rzucczar(postacie[2]);

                if (r.NextDouble() > 0.5)
                    postacie[1].bijwroga(postacie[2]);
                else
                    ((wojownik)postacie[1]).rzuttoporem(postacie[2]);


                if (r.NextDouble() > 0.5 && postacie[0].sprawdzhp()=="zyje")
                    postacie[2].bijwroga(postacie[0]);
                else
                    postacie[2].bijwroga(postacie[1]);

                runda++;
                Console.WriteLine();
            }while(postacie[0].sprawdzhp()!="nie zyje" || postacie[1].sprawdzhp()!="nie zyje"||postacie[2].sprawdzhp()=="nie zyje");

            Console.ReadKey();
        }
        }
    }

