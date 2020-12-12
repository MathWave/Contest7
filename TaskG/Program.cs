using System;

namespace TaskG
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sequence nums = new Sequence(n);
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                nums.Add(num);
                num = int.Parse(Console.ReadLine());
            }

            nums.Print();
        }
    }
}