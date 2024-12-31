using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Abstraction
{
    //concreate Class
    internal class Square : Base
    {
        public Square(decimal Dim):base (Dim,Dim)
        {
            //Dim01 = Dim02 =Dim;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }
        
    }
}
