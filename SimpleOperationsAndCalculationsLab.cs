using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingBasics
{
    class SimpleOperationsAndCalculationsLab
    {
        public static void Tasks()
        {
            //P01SquareArea();
            //P02InchesToCentimeters();
            //P03Greeting();
            //P04ConcatenateData();
            //P05TrapeziodArea();
            //P06CircleAreaAndPerimeter();
            //P07TriangleArea();
            //P08CelsiusToFahrenheit();
            P09Birthday();
        }

        private static void P01SquareArea()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {a * a}");
        }

        private static void P02InchesToCentimeters()
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine($"{number} inches is {number * 2.54} cm");
        }

        private static void P03Greeting()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        private static void P04ConcatenateData()
        {
            string firstNmae = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstNmae} {lastName}, a {age}-years old person from {town}.");
        }

        private static void P05TrapeziodArea()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine($"{((b1 + b2) * h) / 2:F2}");
        }

        private static void P06CircleAreaAndPerimeter()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }

        private static void P07TriangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(a * h) / 2:F2}");
        }

        private static void P08CelsiusToFahrenheit()
        {
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{celsius * 1.8 + 32:F2}");
        }

        private static void P09Birthday()
        {
            Console.WriteLine("Enter lenght: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter percentage: ");
            double percentage = double.Parse(Console.ReadLine());
            double capacity = lenght * width * height * 0.001;
            Console.WriteLine($"{capacity - ((capacity * percentage) / 100):F3}");
        }
    }
}
