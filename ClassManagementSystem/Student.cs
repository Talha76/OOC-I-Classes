using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Student
    {
        public int id { get; }
        public string name { get; }
        public int deptCode { get; }
        public int section { get; }

        public Student(int id, string name, int deptCode, int section)
        {
            this.id = id;
            this.name = name;
            this.deptCode = deptCode;
            this.section = section;
        }
    }
}
