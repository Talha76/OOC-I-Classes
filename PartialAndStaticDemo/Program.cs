using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialAndStaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partial Class demo
            //Car car = new Car();
            //Console.WriteLine(car.openDoor());
            //Console.WriteLine(car.Drive());
            //Console.WriteLine(car.Maintain());

            // Static Demo
            //StaticClass class1 = new StaticClass();
            //StaticClass class2 = new StaticClass();
            //class1.a = 2; class2.a = 3;
            StaticClass.b++;

            Console.WriteLine(StaticClass.b);

            //Console.WriteLine(class1.method1());
            Console.WriteLine(StaticClass.method2());
        }
    }
}
