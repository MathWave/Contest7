using System;

class Program
 {
     static void Main(string[] args)
     {
         int sidesAmount = int.Parse(Console.ReadLine());
         double radius = double.Parse(Console.ReadLine());
         RegularPolygon regularPolygom = new RegularPolygon(sidesAmount, radius);
         Console.WriteLine(regularPolygom.GetPerimeter().ToString("f3"));
         Console.WriteLine(regularPolygom.GetSquare().ToString("f3"));
     }
 }