using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    abstract class PerimeterBase : Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
