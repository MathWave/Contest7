using System;

namespace TaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            Point center = new Point(0, 0);
            Point[] points = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                double[] coordinates = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
                points[i] = new Point(coordinates[0], coordinates[1]);
            }
            for (int i = 0; i < 2; i++)
                for (int j = i; j < 3; j++)
                    if (points[i].DistanceTo(center) > points[j].DistanceTo(center))
                        Point.Swap(ref points[i], ref points[j]);
            foreach (Point p in points)
                p.Print();
        }
    }
}