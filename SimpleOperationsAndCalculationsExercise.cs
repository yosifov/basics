using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingBasics
{
    class SimpleOperationsAndCalculationsExercise
    {
        public static void Tasks()
        {
            //P01UsdToBgn();
            //P02RadiansToDegrees();
            //P032DRectangleArea();
            //P04TailoringWorkshop();
            //P05DanceHall();
            //P06CharityCampaign();
            P07AlcoholMarket();
        }

        private static void P01UsdToBgn()
        {
            double course = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            Console.WriteLine($"{usd * course:F2}");
        }

        private static void P02RadiansToDegrees()
        {
            double radian = double.Parse(Console.ReadLine());
            double degrees = Math.Round((radian * 180) / Math.PI);
            Console.WriteLine(degrees);
        }

        private static void P032DRectangleArea()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            double area = Math.Round(a * b, 2);
            double perimeter = Math.Round(2 * (a + b), 2);
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }

        private static void P04TailoringWorkshop()
        {
            int tableNum = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());
            double coverLenght = tableLength + 0.6;
            double coverWidth = tableWidth + 0.6;
            double coverArea = coverLenght * coverWidth;
            double boxLenght = tableLength / 2;
            double boxArea = boxLenght * boxLenght;
            double usd = 1.85;
            double totalPrice = (coverArea * 7 * tableNum) + (boxArea * 9 * tableNum);
            Console.WriteLine($"{totalPrice:F2} USD");
            Console.WriteLine($"{(totalPrice * usd):F2} BGN");
        }

        private static void P05DanceHall()
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double hallArea = (L * W) * 10000;
            double boxArea = (A * A) * 10000;
            double benchArea = hallArea / 10;
            double emptyHall = hallArea - (boxArea + benchArea);
            double dancers = Math.Floor(emptyHall / 7040);
            Console.WriteLine(dancers);
        }

        private static void P06CharityCampaign()
        {
            // Console Read Data
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            // Calculations
            double totalCakes = cakes * confectioners * days;
            double totalWaffles = waffles * confectioners * days;
            double totalPancakes = pancakes * confectioners * days;

            double cakesPrice = totalCakes * 45;
            double wafflesPrice = totalWaffles * 5.80;
            double pancakesPrice = totalPancakes * 3.20;

            double totalPrice = cakesPrice + wafflesPrice + pancakesPrice;
            double moneyLeft = totalPrice - (totalPrice / 8);

            // Console Write the answer
            Console.WriteLine($"{moneyLeft:F2}");
        }

        private static void P07AlcoholMarket()
        {
            // Console Data Read
            double whiskyPrice = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityWhisky = double.Parse(Console.ReadLine());

            // Calculations
            double rakiaPrice = whiskyPrice / 2;
            double winePrice = rakiaPrice - ((rakiaPrice * 40) / 100);
            double beerPrice = rakiaPrice - ((rakiaPrice * 80) / 100);

            // Print Result
            double totalPrice = (whiskyPrice * quantityWhisky) +
                                (rakiaPrice * quantityRakia) +
                                (beerPrice * quantityBeer) +
                                (winePrice * quantityWine);
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
