﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    internal class Student : IEnumerable<Student>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Grades { get; set; }
    }
}
