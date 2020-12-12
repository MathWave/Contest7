using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        FibNumber fibNumber = new FibNumber(n);
        fibNumber.GetFibNumber();
        fibNumber.Print();
    }
}