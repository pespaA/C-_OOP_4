using OOP_Session4.Assignment;

namespace OOP_Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo.Demo0();


            #region First Project
            Console.WriteLine("Enter value for P1 x : ");
            int P1x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for P1 y : ");
            int P1y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for P1 z : ");
            int P1z = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for P2 x : ");
            int P2x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for P2 y : ");
            int P2y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for P2 z : ");
            int P2z = int.Parse(Console.ReadLine());
            Point3D P1 = new Point3D(P1x, P1y, P1z);
            Point3D P2 = new Point3D(P2x, P2y, P2z);

            if (P1 == P2)// Work But Wrong Answer
                Console.WriteLine("P1 == P2");
            else Console.WriteLine("P1 != P2");


            Point3D[] points = new Point3D[2] {P2,P1};
            Array.Sort(points);
            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            Point3D asd = new Point3D(1, 2, 3).add(10, 10, 10).add(10, 10, 10);
            Console.WriteLine(asd);


            #endregion


            #region Second Project

            Console.WriteLine(Maths.add(5, 5));
            Console.WriteLine(Maths.Subtract(5, 5));
            Console.WriteLine(Maths.Multiply(5, 5));
            Console.WriteLine(Maths.Divide(5, 5));

            #endregion


            #region Third Project
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            //Duration D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());
            Console.WriteLine("-----------------------");
            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = ++D1;
            D3 = --D2;
            D3 = D1 - D2;
            if (D1 > D2)
                Console.WriteLine("D1 > D2");
            else Console.WriteLine("not");
            if (D1 <= D2)
                Console.WriteLine("D1 <= D2");
            else Console.WriteLine("not");

            Console.WriteLine(D3.ToString());
            if(D1)
                Console.WriteLine("D1 is not 0");

            DateTime Obj = (DateTime)D1;

            #endregion
        }
    }
}
