using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Department
    {
        private string name;
        private int code;

        public Department(string name, int code)
        {
            this.name = name;
            this.code = code;
        }

        ~Department() { }
    }
}
