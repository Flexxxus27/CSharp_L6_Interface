using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public class TeamLid : Paycheck
    {
        public int Salary { get; set; }
        public string Name { get; set; }
        public int JobDay { get; set; }
        public double CalculateSalary()
        {
            return Salary = JobDay * 2500;
        }
    }
}
