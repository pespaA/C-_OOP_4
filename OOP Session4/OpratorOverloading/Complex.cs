using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.OpratorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} , {Imag}";
        }

        #region Binary Opertors
        // Overloading Orertors : Must By Non - Private Class Member Function
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0),
            };
        }
        #endregion
        #region Unery Oprtors

        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)

            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)

            };
        }

        #endregion
        #region Relational Operators
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
        #region Casting Operator
        public static explicit operator int (Complex C)
        {
            return C?.Real?? 0;
        }
        public static implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }

        #endregion
    }
}
