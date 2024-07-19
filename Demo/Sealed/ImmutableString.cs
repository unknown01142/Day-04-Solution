using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    sealed class ImmutableString
    {

        public string Value { get { return Value; }  }

        private readonly string _value;
        public ImmutableString(string value)
        {

            this._value = value;
        }
    }




}
