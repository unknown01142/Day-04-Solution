﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    partial class Employee
    {
        public string? Address { get; set; }

        partial void DoSomeCode()
        {
            
        }

    }
}
