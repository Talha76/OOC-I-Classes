using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Professor : Teacher
    {
        public Professor(int id, string name, Department dept) : base(id, name, dept)
        {

        }
    }
}
