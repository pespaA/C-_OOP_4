using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Sealed
{
    internal class Parent
    {
        private int salary;
        public virtual int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public virtual void Print()
        {
            Console.WriteLine("I am Parent");
        }
    }
    class Child:Parent
    {
        public sealed override int Salary 
        { 
            get {return base.Salary;}
            set { base.Salary = value; } 
        }
        //Sealed Method 
        public sealed override void Print()
        {
            Console.WriteLine("I am Child");
        }
    }
    // Sealed Class 
    sealed class GrandChild:Child
    {
        //public sealed override void Print() // cannot Bc its Sealed in Child
        //{
        //    Console.WriteLine("I am Child");
        //}
    }
}
