using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
   
       abstract class bohater : Ibohater
       {
           public double Hp { get; protected set; }
           public double Atak { get; protected set; }
           public rasyenum.rasy Rasa { get; private set; }

           public string sprawdzhp()
           {
               if (Hp > 0.0)
               {
                   return "zyje";
               }
               else
               {
                   return "nie zyje";
               }
           }

           public void bijwroga(bohater cel)
           {
               if (sprawdzhp() == "zyje")
               
                   cel.wpi(Atak);
               
           }


           public double wpi(double dmg)
           {
               return Hp -= dmg;
           }

          
       }
    }

