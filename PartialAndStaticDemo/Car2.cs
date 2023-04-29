using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialAndStaticDemo
{
    internal partial class Car
    {
        public string Drive() { return "Car is being driven."; }
        public string Maintain() { return "Car is being maintained."; }
    }
}
