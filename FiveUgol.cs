﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public class FiveUgol : INUgol
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double Corner { get; set; }
        public int Count { get; set; }
        public List<double> Length { get; set; }
        public double S()
        {
            double ans = P() / 2;
            foreach(var a in Length)
            {
                ans *= ans - a;
            }
            return Math.Sqrt(ans);
        }
        public double P()
        {
            double ans = 0;
            foreach (var a in Length)
            {
                ans += a;
            }
            return ans;
        }
    }
}
