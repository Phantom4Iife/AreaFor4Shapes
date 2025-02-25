// See https://aka.ms/new-console-template for more information
using System;

namespace AreaFor4Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double radius, circleArea;
            Console.WriteLine("Enter the radius of the circle");
            radius = Convert.ToDouble(Console.ReadLine());

            circleArea = Math.PI * radius *radius;

            Console.WriteLine("\nArea of a Circle with radius {0} is {1}",radius, circleArea);

        }
    }
}