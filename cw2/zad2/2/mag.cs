using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class mag : bohater
    {
       public int Mana { get; private set; }

        public mag(int mana, double hp, rasyenum.rasy rasa,double atak)
        {
            Mana = mana;
            Hp = hp;
            rasa = Rasa;
            Atak = atak;
        }
        public void rzucczar(bohater cel)
        {
            if (sprawdzhp() == "zyje"&& Mana>0)
            {
                cel.wpi(Atak*1.3);
                Mana--;
            }
            else
            {
                return;
            }
        }
    }
}
