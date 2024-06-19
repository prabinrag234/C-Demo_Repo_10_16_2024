using System;

namespace Abstractmembers.PRTK
{
    public abstract class Abstractmember
    {
        public double length,height,radius;
        public const float pi = 3.14f;
        public abstract double area();
    }

    public class Circle : Abstractmember
    {
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double area()
        {
            return pi * (radius * radius);
        }
    }
    public class Rectangle : Abstractmember
    {
        public Rectangle(int length, int height)
        {
            this.length = length;
            this.height = height;
        }
        public override double area()
        {
            return length * height;
        }
    }
    public class Triangle : Abstractmember
    {
        public Triangle(int length, int hight)
        {
            this.length = length;
            this.height = hight;
        }
        public override double area()
        {
            return 1/2*length*height;
        }
    }

    public class test
    {
        public static void Main()
        {
            Circle circle = new Circle(15);
            Rectangle rectangle = new Rectangle(42,24);
            Triangle triangle = new Triangle(12,52);

            Console.WriteLine("Area of Circle is " + circle.area());
            Console.WriteLine("Area of Circle is " + rectangle.area());
            Console.WriteLine("Area of Circle is " + triangle.area());

            Console.ReadLine();
        }
    }
}
