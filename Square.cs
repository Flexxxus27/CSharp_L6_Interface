﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public class Square : Figure
    {
        public double A { get; set; }
        public override double S()
        {
            return A * A;
        }
        public override double P()
        {
            return A * 4;
        }
    }
}
