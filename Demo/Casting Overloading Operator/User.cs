﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Overloading_Operator
{
    // Model : Is a Class that Represent a Data in a Table
    class User
    {

        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public Guid? SecurityStmp { get; set; }

       


    }
}
