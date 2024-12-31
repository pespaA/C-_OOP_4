using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Static_And_Constatns
{
    internal class Utility
    {
        public int X { get; set; }
        public double Y { get; set; }

        #region Static Proprty
        private const double pi = Math.PI;
        //Static Attribute 
        //private static double pi = default;//0
        // Compiler Will Intialize The Static Attributes With The Default Value Of Attribute
        //Class Member Property : Static Property
        //Get And Set One Of This 
        // 1- Static Attribute 
        // 2- Constant
        public static double PI
        {
            get { return pi; }
            //set { pi = value; }
        }
        #endregion
        public Utility(int _X,double _Y)
        {
            X = _X;
            Y = _Y;
            // PI = Math.PI; Is not The Right Place For Intializing The Static Attribute 
        }

        // Static Constructor [Maximum One Static Constructor For Class]
        //CanNot Specify Access Modifier Or Parameters For Static Constructor
        //Will Be Called [Executed ] just Only One Time Per Class Life Time Before The First Usege Of Class
        //Usage Of Class 
        // 1- Call Static Method or static Proprty
        // 2- Create Object From this Class
        // 3- Create Object From Another Class Inheriting From This Class
        static Utility()
        {
            //pi = Math.PI;
        }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }
        
        //Class Member Method : Static Method 
        public static double CmToInch (double Cm)
        {
            return Cm / 2.54;
        }

        public static double ClacCircleArea (double Radius)
        {
            return Radius * Radius * Utility.pi;
        }
    }
}
