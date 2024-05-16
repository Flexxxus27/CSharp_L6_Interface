using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L6
{
    public interface IAbc
    {
        bool A {  get; set; }
        void Ab();
    }
    // IEnumerable (Current return object), (MoveNext() return bool), (Reset() void)
    // (Get Enumerator() return IEnumerator)
    // IComparable (CompareTo(object) return int)
    //IComparer (Compare(object, object)
    //ICloneable (Clone() return object)
    
}
