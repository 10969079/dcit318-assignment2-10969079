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
        Console.WriteLine("Calculating area of Circle");
        // Calculate area of circle
        return Math.PI * radius * radius;
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
        Console.WriteLine("Calculating area of Rectangle");
        // Calculate area of rectangle
        return length * width;
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double enteredRadius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(enteredRadius);

        Console.WriteLine("Circle Area: " + circle.GetArea());


        Console.Write("Enter the length of the rectangle: ");
        double enteredLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double enteredWidth = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(enteredLength, enteredWidth);

        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
    }
}