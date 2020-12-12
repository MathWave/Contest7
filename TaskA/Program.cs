using System;

class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(n);
        Console.WriteLine(triangle.GetPerimeter().ToString("f3"));
        Console.WriteLine(triangle.GetSquare().ToString("f3"));
    }
}
