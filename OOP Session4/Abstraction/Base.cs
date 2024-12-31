using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Abstraction
{
    internal class Base : Shape
    {
        public override decimal Perimeter => throw new NotImplementedException();

        public Base(decimal _Dim01, decimal _Dim02):base (_Dim01,_Dim02)
        {
            Dim01 = _Dim01;
            Dim02 = _Dim02;
        }
        public override decimal CalcArea()
        {
            return Dim02 * Dim01;
        }
    }
}
