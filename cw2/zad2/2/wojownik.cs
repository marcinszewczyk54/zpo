using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class wojownik:bohater

    {
        public wojownik(double hp,rasyenum.rasy rasa,double atak)
        {
            Atak = atak;
            Hp = hp;
            rasa = Rasa;
        }

        public void rzuttoporem(bohater cel)
        {
            if (sprawdzhp() == "zyje")
            {
                cel.wpi(Atak * 2.0);
                
            }
            else
            {
                return;
            }
        }
    }
}
