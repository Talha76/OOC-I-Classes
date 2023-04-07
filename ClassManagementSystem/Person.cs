using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Person
    {
        public int id { get; }
        public string name { get; }
        public Department dept { get; }

        public Person(int id, string name, Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
    }
}
