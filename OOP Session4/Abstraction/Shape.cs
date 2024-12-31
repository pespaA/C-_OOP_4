using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Abstraction
{
    internal abstract class Shape // not Full Implemented
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal Perimeter { get; }
        public Shape(decimal _Dim01, decimal _Dim02)
        {
            Dim01 = _Dim01;
            Dim02 = _Dim02;
        }
        public abstract decimal CalcArea();
    }
}
