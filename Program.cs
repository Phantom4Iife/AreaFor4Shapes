// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Serialization;
using System.Threading;

namespace AreaFor4Shapes
{
    internal class Program
    {
        static void TypeWriter(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay); // Creates the typewriter effect
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                TypeWriter("Hi... This program will calculate the area of 4 different shapes below");
                TypeWriter("1. Circle");
                TypeWriter("2. Triangle");
                TypeWriter("3. Rectangle");
                TypeWriter("4. Square");
                TypeWriter("\nType one of the given shapes above");

                string choice = Console.ReadLine().ToLower();

                if (choice == "circle")
                {
                    TypeWriter("Enter the radius of the circle: ");
                    if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
                    {
                        double area = Math.PI * Math.Pow(radius, 2);
                        TypeWriter($"The area of a circle is: {area}");
                    }
                    else
                    {
                        TypeWriter("Radius is not valid. Enter a positive number.");
                    }
                }
                else if (choice == "triangle")
                {
                    TypeWriter("Enter the base of the triangle: ");
                    if (double.TryParse(Console.ReadLine(), out double baseLength) && baseLength > 0)
                    {
                        TypeWriter("Enter the height of the triangle: ");
                        if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                        {
                            double area = 0.5 * baseLength * height;
                            TypeWriter($"The area of the triangle is: {area}");
                        }
                        else
                        {
                            TypeWriter("Height is not valid. Please enter a positive number.");
                        }
                    }
                    else
                    {
                        TypeWriter("base is not valid. Please enter a positive number.");
                    }
                }
                else if (choice == "rectangle")
                {
                    TypeWriter("Enter the length of the rectangle: ");
                    if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
                    {
                        TypeWriter("Enter the width of the rectangle: ");
                        if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
                        {
                            double area = length * width;
                            TypeWriter($"The area of the rectangle is: {area}");
                        }
                        else
                        {
                            TypeWriter("Width is not valid. Please enter a positive number.");
                        }
                    }
                    else
                    {
                        TypeWriter("Length is not valid. Please enter a positive number.");
                    }
                }

                else if (choice == "square")
                {
                    TypeWriter("Enter the side length of the square: ");
                    if (double.TryParse(Console.ReadLine(), out double side) && side > 0)
                    {
                        double area = side * side;
                        TypeWriter($"The area of the square is: {area}");
                    }
                    else
                    {
                        TypeWriter("Side length is not valid. Please enter a positive number.");
                    }
                }
                else if (choice == "5") 
                {
                    TypeWriter("Exiting the program. Goodbye!");
                    break; 

                }
                else
                {
                    TypeWriter("Invalid choice. Please enter one of the shapes given above");
                }

                TypeWriter("\nPress 5 to exit");

                Console.ReadKey();

            }
        }
    }
}