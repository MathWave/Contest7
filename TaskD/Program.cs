using System;

class Program
{
    static void Main(string[] args)
    {
        Int n = new Int(int.Parse(Console.ReadLine()));
        Console.WriteLine(n.ToNotation(int.Parse(Console.ReadLine())));
        Console.WriteLine(n.ToNotation(int.Parse(Console.ReadLine())));
    }
}