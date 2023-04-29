using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterfaceCasting
{
    internal class Student : Person
    {
        public string name { get; }
        public int age { get; }
        public string description { get; }
        public string address { get; }

        public Student(string name) { this.name = name; }
        
        public string walk(int distance) { return "Student " + name + " walked " + distance; }
    }
}
