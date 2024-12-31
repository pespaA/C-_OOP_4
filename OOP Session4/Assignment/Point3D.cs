using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Assignment
{
    internal class Point3D: IComparable, ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Point3D(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public Point3D add(int x,int y,int z)
        {
            this.x += x;
            this.y += y;
            this.z += z;
            return new Point3D(this.x,this.y,this.z);
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

    }
}
