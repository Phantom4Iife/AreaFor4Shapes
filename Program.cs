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



            double baseLength, height, triangleArea;

            Console.WriteLine("\nEnter the baseLength of the triangle");

            baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the height of the triangle");

            height = Convert.ToDouble(Console.ReadLine());



            triangleArea = .5 * baseLength * height;



            Console.WriteLine("\nArea of a Triangle with baseLength of {0} and height of {1} is {2}", baseLength, height, triangleArea);

        }
    }
}