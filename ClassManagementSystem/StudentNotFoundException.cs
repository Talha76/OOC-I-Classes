using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class StudentNotFoundException : ApplicationException
    {
        public StudentNotFoundException() : base("Student Not Found.") { }
    }
}
