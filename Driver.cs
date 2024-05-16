using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public class Driver : Iworker
    {
       public bool IsWorking { get; set; }
        public string Work()
        {
            return "Водитель работает.";
        }
    }
}
