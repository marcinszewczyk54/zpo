using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class AppleFabryka:IFabryka
    {
        public IEkran produkujEkran()
        {
            return new AppleEkran();
        }

        public IObudowa produkujObudowe()
        {
            return new AppleObudowa();
        }
    }
}
