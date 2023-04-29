using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterfaceCasting
{
    internal class Teacher
    {
        public string name { get; }
        public int id { get; }

        public Teacher(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
