﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public interface Iworker
    {
        bool IsWorking { get; }
        string Work();
    }
}
