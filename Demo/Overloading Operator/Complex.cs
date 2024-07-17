using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overloading_Operator
{
    class Complex
    {
        #region Operator Overloading

        // Overloading Operator: Must be Non-Private Class Member Function

        #region Binary Operator

        public int Real { get; set; }
        public int Imag { get; set; }

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = Left?.Real ?? 0 + Right?.Real ?? 0,
                Imag = Right?.Imag ?? 0 + Left?.Imag ?? 0,
            };

        }


        #region Method
        public override string ToString()
        {
            return $"{Real}+{Imag}i";
        }

        #endregion

        #endregion

        #region Unary Operator
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0),

            };

        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0),

            };

        }
        #endregion

        #region Relational Operator

        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
                return Left?.Imag > Right?.Imag;
            else
                return Left?.Real > Right?.Real;

        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
                return Left?.Imag < Right?.Imag;
            else
                return Left?.Real < Right?.Real;
        }




        #endregion




        #endregion
    }
}

