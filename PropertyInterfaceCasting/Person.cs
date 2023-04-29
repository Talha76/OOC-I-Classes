using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterfaceCasting
{
    // Interface may include method prototypes, properties
    // No access-modifiers in methods and properties;
    internal interface Person
    {
        string name { get; }
        string description { get; }
        int age { get; }
        string address { get; }

        string walk(int distance);
    }
}
