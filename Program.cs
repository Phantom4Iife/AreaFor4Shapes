﻿// See https://aka.ms/new-console-template for more information
using System;

namespace AreaFor4Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Area of circle
            double radius, circleArea;
            Console.WriteLine("Enter the radius of the circle");
            radius = Convert.ToDouble(Console.ReadLine());

            circleArea = Math.PI * radius *radius;
            Console.WriteLine("\nArea of a Circle with radius {0} is {1}",radius, circleArea);


            //Area of Triangle
            double baseLength, height, triangleArea;

            Console.WriteLine("\nEnter the baseLength of the triangle");

            baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the height of the triangle");

            height = Convert.ToDouble(Console.ReadLine());



            triangleArea = .5 * baseLength * height;
            Console.WriteLine("\nArea of a Triangle with baseLength of {0} and height of {1} is {2}", baseLength, height, triangleArea);


            //Area of Rectangle
            double length, width, rectangleArea;

            Console.WriteLine("\nEnter the length of the rectangle");

            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Enter the width of the rectangle");

            width = Convert.ToDouble(Console.ReadLine());



            rectangleArea = length * width;
            Console.WriteLine("\nArea of a Rectangle with length of {0} and width {1} is {2}", length, width, rectangleArea);


            //Area of Square
            double side, squareArea;

            Console.WriteLine("\nEnter the length of the square side");

            side = Convert.ToDouble(Console.ReadLine());



            squareArea = side * side;

            Console.WriteLine("\nArea of a Square with length of {0} is {1}", side, squareArea);




            Console.WriteLine("\nPress any key to exit");

            Console.ReadKey();

        }
    }
}