﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability_Example
{
    public interface IHandler
    {
        IHandler Next { set; }
    }
}
