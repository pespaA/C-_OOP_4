using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOP_Session4.Abstraction;
using OOP_Session4.OpratorOverloading;
using OOP_Session4.Static_And_Constatns;

namespace OOP_Session4
{
    internal class Demo
    {
        public static void Demo0()
        {

            #region Overloading Oprators

            Complex C1 = new Complex() { Real = 2, Imag = 4 };
            Complex C2 = new Complex() { Real = 3, Imag = 5 };

            #region Binary Oprator

            //Complex C3 = C1 + C2 ;
            ////C2 += C1; // C2 = C2 + C1
            //Console.WriteLine($"C1 : {C1}");
            //Console.WriteLine($"C2 : {C2}");
            //Console.WriteLine($"C3 : {C3}");// "C3 : 5 , 9"
            //-----------------------------------
            //Complex C3 = C1 - C2;
            ////C2 -= C1; // C2 = C2 - C1
            //Console.WriteLine($"C1 : {C1}");
            //Console.WriteLine($"C2 : {C2}");
            //Console.WriteLine($"C3 : {C3}");// "C3 : -1 , -1"
            #endregion
            #region Unary Oprator
            //Complex C3 = ++C1;
            //Console.WriteLine($"C1: {C1}");
            //Console.WriteLine("After ++C1");
            //C3++;
            //Console.WriteLine($"C3: {C3}");
            //------------------------------
            //Complex C3 = --C1;
            //Console.WriteLine($"C1: {C1}");
            //Console.WriteLine("After --C1");
            //Console.WriteLine($"C3: {C3}");
            #endregion
            #region Relational Opertor
            //if (C1 > C2)
            //    Console.WriteLine("C1 is Greater Than C2");
            //else if (C1 < C2)
            //    Console.WriteLine("C1 is Less Than C2");
            //else
            //    Console.WriteLine("C1 is Less Than C2");

            #endregion
            #region Casting Operator

            #region Example 01
            //int Y = (int)C1;
            //Console.WriteLine(Y);

            //object o1 = 5;
            //int x = (int)o1;
            //Console.WriteLine(x); 
            #endregion
            #region Example 02
            // Recommended To Be Explicict
            //string Y = /*(string)*/C1; // Implicict Casting
            //Console.WriteLine(Y);
            //object O1 = "Omar";
            //string X = (string)O1;
            //Console.WriteLine(X);

            #endregion

            #endregion
            #region Business Need For Operator Overloading
            //User user = new User()
            //{
            //    Id = 123,
            //    FullName = "Omar Ahmed",
            //    Email = "Omar@gmail.com",
            //    Password = "123456",
            //    SecurityStmp = Guid.NewGuid()
            //};
            //// Manaul Mapping
            //UserViewModel userViewModel = (UserViewModel) user;
            //Console.WriteLine(userViewModel.Id);
            //Console.WriteLine(userViewModel.Fname);
            //Console.WriteLine(userViewModel.Lname);
            //Console.WriteLine(userViewModel.Email);
            //Console.WriteLine(userViewModel.Password);

            #endregion

            #endregion
            #region Abstraction
            //Rectangle rectangle = new Rectangle()
            //{
            //    Dim01 = 10,
            //    Dim02 = 20,
            //};
            //decimal recArea = rectangle.CalcArea();
            //decimal recPeri = rectangle.Perimeter;
            //Console.WriteLine($"rec Area = {recArea}");
            //Console.WriteLine($"rec Perimeter = {recPeri}");
            //--------------------------------
            //Circle circle = new Circle(10);
            //decimal circleArea = circle.CalcArea();
            //decimal circlePeri = circle.Perimeter;
            //Console.WriteLine($"Circle Area : {circleArea}\nCircle Peri : {circlePeri}");


            #endregion
            #region Abstract Class Vs Interface

            #endregion
            #region Static [ Class - Method - Constructor - Attribute - Property ]
            //Utility U1 = new Utility(1, 2);
            //Console.WriteLine(Utility.CmToInch(254));
            //Utility U2 = new Utility(1, 2);
            //Console.WriteLine(Utility.CmToInch(254));
            ////The Result Of Calling Method "CmToInch" Will Not Be Different By Difference Of The Objects
            //Console.WriteLine($"Circle Area = {Utility.ClacCircleArea(10)}");
            #endregion
            #region Sealed [ Class - Method - Property ] 

            #endregion
            #region Partial [ Class - Struct - Interface - Method ]

            #endregion
            #region Class Summary

            #endregion

        }
    }
}
