﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    internal class Lecturer : Teacher
    {
        public Lecturer(int id, string name, Department dept) : base(id, name, dept)
        {

        }
    }
}
