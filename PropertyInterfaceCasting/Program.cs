using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterfaceCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher("Random name", 2);
            //Console.WriteLine("Teacher name: " + teacher.name);

            //teacher.name = "another name";

            // Interface demo
            //Student student = new Student("a student");
            //Console.WriteLine(student.walk(100));

            // Upcasting demo(Civil -> Person)
            Person person1 = new Civil("talha");
            Console.WriteLine(person1.walk(10));

            // Downcasting demon(Person -> Civil)
            Civil civil = (Civil)person1;
            Console.WriteLine(civil.walk(10));

            Student student = (Student)person1;
            Console.WriteLine(student.walk(10));

            //Civil civil = new Civil("talha");
            //Console.WriteLine(civil.walk(10));

            //Student student = new Student("mushfiq");
            //Console.WriteLine(student.walk(10));
        }
    }
}
