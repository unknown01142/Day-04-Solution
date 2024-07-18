using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract Class
    // is a Partial Implementation for Other Classes.
    // is a Container for Common Code [ Fully Implemented Members, Abstract Members ] among many classes.
    // U Can't Create an Object from Abstract Class [ it is not fully implemented].

    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        // Abstract Property
        public abstract decimal Perimeter { get; }


        // Abstract Method 
        public abstract decimal CalcArea();

    }

    


}
