using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    public static void Main()
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        car.Move();
        bicycle.Move();
    }
}