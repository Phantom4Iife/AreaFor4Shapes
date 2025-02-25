// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Serialization;

namespace AreaFor4Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("Hi... This program will calculate the area of 4 different shapes below");
            Console.WriteLine("1. circle");
            Console.WriteLine("2. triangle");
            Console.WriteLine("3. rectangle");
            Console.WriteLine("4. square");
            Console.WriteLine("\nChoose one of the given shapes above in lower case");

            string choice = Console.ReadLine();

            if (choice == "circle")
            {
                Console.Write("Enter the radius of the circle: ");
                if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
                {
                    double area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"The area of a circle is: {area}");
                }
                else
                {
                    Console.WriteLine("Radius is not valid. Enter a positive number.");
                }
            }
            else if (choice == "triangle")
            {
                Console.Write("Enter the base of the triangle: ");
                if (double.TryParse(Console.ReadLine(), out double baseLength) && baseLength > 0)
                {
                    Console.Write("Enter the height of the triangle: ");
                    if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                    {
                        double area = 0.5 * baseLength * height;
                        Console.WriteLine($"The area of the triangle is: {area}");
                    }
                    else
                    {
                        Console.WriteLine("Height is not valid. Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("base is not valid. Please enter a positive number.");
                }
            }
            else if (choice == "rectangle")
            {
                Console.Write("Enter the length of the rectangle: ");
                if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
                {
                    Console.Write("Enter the width of the rectangle: ");
                    if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
                    {
                        double area = length * width;
                        Console.WriteLine($"The area of the rectangle is: {area}");
                    }
                    else
                    {
                        Console.WriteLine("Width is not valid. Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Length is not valid. Please enter a positive number.");
                }
            }

            else if (choice == "square")
            {
                Console.Write("Enter the side length of the square: ");
                if (double.TryParse(Console.ReadLine(), out double side) && side > 0)
                {
                    double area = side * side;
                    Console.WriteLine($"The area of the square is: {area}");
                }
                else
                {
                    Console.WriteLine("Side length is not valid. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter one of the shapes given above");
            }

            Console.WriteLine("\nPress any key to exit");

            Console.ReadKey();

        }   
    }
}