using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Student : Person
    {
        public int section { get; }

        public Student(int id, string name, Department dept, int section) : base(id, name, dept)
        {
            this.section = section;
        }
    }
}
