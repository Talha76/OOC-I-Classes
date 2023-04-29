using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Professor : Teacher
    {
        public Professor(string name) : base(name) { }

        public override string teach()
        {
            return name + " is a Professor who takes both theory and lab courses.";
        }

        public override string getDesignation()
        {
            return "Professor";
        }
    }
}
