using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    class Square : PerimeterBase
    {

        public Square(int Dim)
        {
            this.Dim01 = this.Dim02 = Dim;
        }

        public override decimal Perimeter
        {
             get{ return Dim01 * 4;}
        }

        
    }
}
