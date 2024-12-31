using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Abstraction
{
    internal class Triangle : Shape
    {
        public decimal Dim03 { get; set; }
        public Triangle(decimal _Dim01,decimal _Dim02,decimal _Dim03):base (_Dim01,_Dim02)
        {
            
        }
        public override decimal Perimeter => throw new NotImplementedException();

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
