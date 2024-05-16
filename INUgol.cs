using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public interface INUgol 
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double Corner {  get; set; }
        public int Count { get; set; }
        public List<double> Length { get; set; }
        public double S();
        public double P();
    }
}
