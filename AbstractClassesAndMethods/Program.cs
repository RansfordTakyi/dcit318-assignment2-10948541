
// AbstractClassesAndMethods/Program.cs
using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Shape myCircle = new Circle(5.0);
        Shape myRectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Circle Area: {myCircle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {myRectangle.GetArea()}");
    }
}