using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Department
    {
        public string name { get; }
        public int code { get; }
        
        public Department(string name, int code)
        {
            this.name = name;
            this.code = code;
        }
    }
}
