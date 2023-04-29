using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialAndStaticDemo
{
    // Open Door
    // Close Door
    // Drive
    // Maintenance
    internal partial class Car
    {
        public string openDoor() { return "Door Opened"; }
        public string closeDoor() { return "Door Closed"; }
    }
}
