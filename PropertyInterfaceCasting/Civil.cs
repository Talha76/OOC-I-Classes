using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterfaceCasting
{
    internal class Civil : Person
    {
        public string name { get; }

        public string description { get; }

        public int age { get; }

        public string address { get; }

        public Civil(string name) { this.name = name; }

        public string walk(int distance)
        {
            return "Civil " + name + " walked " + distance;
        }
    }
}
