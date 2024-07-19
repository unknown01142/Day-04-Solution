﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    partial class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set; }

        // Partial Method 
        partial void DoSomeCode();
        public void Test() 
        {
            DoSomeCode();
        }

    }
}
