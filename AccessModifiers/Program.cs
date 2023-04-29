using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lecturer teacher1 = new Lecturer("lecturer");
            Professor teacher2 = new Professor("professor");
            Console.WriteLine("Teacher name: " + teacher1.getName());
            Console.WriteLine("Teacher Designation: " + teacher1.getDesignation());
            Console.WriteLine("Teacher teaches: " + teacher1.teach());
            Console.WriteLine("");

            Console.WriteLine("Teacher name: " + teacher2.getName());
            Console.WriteLine("Teacher Designation: " + teacher2.getDesignation());
            Console.WriteLine("Teacher teaches: " + teacher2.teach());
        }
    }
}
