﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        public string? FName { get; set; }
        public string? LName { get; set; }

        Department Department { get; set; }
        
    
    }
    internal class Department
    {
        public string Name { get; set; }
        public int Code { get; set; }

        
    }
}
