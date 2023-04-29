using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorGetterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department("cse", 4);

            Console.WriteLine("This department's name is " + dept.getName() + " with code " + dept.getCode());

            dept.setName("eee");
            dept.setCode(2);
            //dept.name = "eee";
            //dept.code = 2;
        }
    }
}
