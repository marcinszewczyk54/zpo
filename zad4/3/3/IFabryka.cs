﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    interface IFabryka
    {
        IEkran produkujEkran();
        IObudowa produkujObudowe();

    }
}
