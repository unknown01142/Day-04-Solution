using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    class Rect : PerimeterBase
    {
        public override decimal Perimeter { get { return (Dim01 + Dim02) * 2; }  }

        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }


    }
}
