using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public class ManagerDriver : Iworker, IManager
    {
        List<Iworker> workers;
        public bool IsWorking { get; set; }
        public string Work()
        {
            return "Водитель работает.";
        }
        public string Manage()
        {
            return "Управляет водителями";
        }
    }
}
