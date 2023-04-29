using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Lecturer : Teacher
    {
        public Lecturer(string name) : base(name) { }

        public void setName(string name)
        {
            this.name = name;
        }

        public override string teach()
        { return name + " is a lecturer who teaches only lab courses."; }

        public override string getDesignation()
        {
            return "Lecturer";
        }
    }
}
