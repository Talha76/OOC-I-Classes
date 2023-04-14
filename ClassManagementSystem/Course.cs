using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Course
    {
        public string name { get; }
        public int code { get; }

        public Course(int code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
