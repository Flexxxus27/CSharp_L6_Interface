using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public class Buhgalteria 
    {
        
        public double NalogSalary(Paycheck obj, int JobDay)
        {
            
            int a;
            a = (obj.Salary / 100) * 13;
            return obj.Salary * a;
        }
        
        
    }
}
