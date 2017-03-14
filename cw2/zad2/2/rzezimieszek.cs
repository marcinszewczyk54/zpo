using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class rzezimieszek:bohater
    {
        public double Energia { get; private set; }

        public rzezimieszek(double energia,rasyenum.rasy rasa,double hp,double atak)
        {
            Energia = energia;
            rasa = Rasa;
            Hp = hp;
            atak = atak*energia;
        }

        public void bijwroga(bohater cel)
        {

        }
    }
    
}
