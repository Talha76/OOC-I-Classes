using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorGetterSetter
{
    internal class Department
    {
        private string name;
        private int code;

        public Department()
        {
            Console.WriteLine("An instance has been created.");
        }

        public Department(string name, int code)
        {
            this.name = name;
            this.code = code;
        }

        // Getter for name
        public string getName() { return name; }

        // Getter for code
        public int getCode() { return code; }

        // Setter for name
        public void setName(string name) { this.name = name; }

        // Setter for code
        public void setCode(int code) { this.code = code; }

        ~Department()
        {
            Console.WriteLine("This instace has been destroyed.");
        }
    }
}
