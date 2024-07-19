using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    class Parent
    {
        // Sealed Property
        public /*sealed*/ virtual decimal Salary { get; set; }
        
        // Sealed Method  
        public /*sealed*/ virtual void Print() 
        {
            Console.WriteLine("I am Base");
        }
    }

    class Child : Parent
    {
        public override decimal Salary
        {
            get => base.Salary;
            set => base.Salary = value < 500 ? 5000 : value;
        }

        public new void Print()
        {
            Console.WriteLine("I am Child"); // I am Base  
        }
    }

    class GrandChild : Child
    {
       
    }



}
