using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    abstract internal class Teacher
    {
        protected string name;

        public Teacher(string name) { this.name = name; }

        public string getName() { return name; }

        public abstract string teach();

        public virtual string getDesignation()
        {
            return "It is a global teacher";
        }
    }
}
