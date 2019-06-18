using System;
using System.Linq;

namespace Week5_Day1
{
//2D Point
//Create a Point2D class that has the following properties

//X
//Y
//Create 2 constructors for your Point2D class

//A constructor that takes no input, and sets the point to(0,0).
//A constructor that takes in the x and y corrdinates for the point.
//Your Point2D class should override the ToString() method, and return a string of the form: "(7, 5)".

//Your Point2D class should override the Equals(Object o) method, and should return true if the object passed in o is a Point2D instance, and if the its X and Y properties, match the X and Y properties of this instance.

//3D Point
//Create a Point3D class that extends your 2D Point and has the following property

//Z
//Create 2 constructors for your Point3D class

//A constructor that takes no input, and sets the point to(0,0,0).
//A constructor that takes in the x, y and z coordinates for the point.
//Your Point3D class should override the ToString() method, and return a string of the form: "(7, 5, 12)".

//Your Point3D class should override the Equals(Object o) method, and should return true if the object passed in o is a Point3D instance, and if the its X, Y and Z properties, match the X, Y and Z properties of this instance.
    public class Point2D
    {
        int X;
        int Y;
        object b;

        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object o)
        {
            if (o.GetType().Equals(this.GetType()))
            {
                Point2D point = (Point2D)o;
                return this.X == point.X && this.Y == point.Y;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            // return "(" + X + ", " + Y + ")";
            return $"({X}, {Y})";
        }
    }

    public class Point3D : Point2D
    {
        public Point3D()
        {
            // your code here
        }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            // your code here
        }

        // your code here
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Point2D p1 = new Point2D();
            Point2D p2 = new Point2D(7, 5);
            Point2D p3 = new Point2D(-2, 4);
            Point2D p4 = new Point2D(7, 5);

            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);
            Console.WriteLine("p3 = {0}", p3);
            Console.WriteLine("p4 = {0}", p4);

            Console.WriteLine("p2 == p3? {0}", p2 == p3);
            Console.WriteLine("p2.Equals(p3)? {0}", p2.Equals(p3));
            Console.WriteLine("p2 == p4? {0}", p2 == p4);
            Console.WriteLine("p2.Equals(p4)? {0}", p2.Equals(p4));

            Console.WriteLine("========");

            Point3D p5 = new Point3D();
            Point3D p6 = new Point3D(7, 5, 12);
            Point3D p7 = new Point3D(-2, 4, -4);
            Point3D p8 = new Point3D(7, 5, 12);

            Console.WriteLine("p5 = {0}", p5);
            Console.WriteLine("p6 = {0}", p6);
            Console.WriteLine("p7 = {0}", p7);
            Console.WriteLine("p8 = {0}", p8);

            Console.WriteLine("p6 == p7? {0}", p6 == p7);
            Console.WriteLine("p6.Equals(p7)? {0}", p6.Equals(p7));
            Console.WriteLine("p6 == p8? {0}", p6 == p8);
            Console.WriteLine("p6.Equals(p8)? {0}", p6.Equals(p8));
            
            Console.WriteLine("========");
        }
    }
}
