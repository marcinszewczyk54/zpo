using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class SamsungFabryka:IFabryka
    {
        public IEkran produkujEkran()
        {
          return new SamsungEkran();
        }

        public IObudowa produkujObudowe()
        {
            return new SamsungObudowa();
        }
    }
}
