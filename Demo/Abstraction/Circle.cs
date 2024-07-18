using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    class Circle : Shape
    {
        public Circle(decimal Radious) 
        {
        this.Dim01 = Dim02 = Radious;
        }
        public override decimal Perimeter
        {
            get { return 2 * 3.14M * Dim01; }
        }

        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim02;
        }
    }
}
