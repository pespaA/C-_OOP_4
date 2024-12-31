using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Abstraction
{
    //Concreate Class
    internal class Rectangle:Base // Implement And Inherit
    {
        public Rectangle(decimal _Dim01, decimal _Dim02) : base(_Dim01, _Dim02)
        {
            //Dim01 = _Dim01;
            //Dim02 = _Dim02;
        }
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
    }
}
