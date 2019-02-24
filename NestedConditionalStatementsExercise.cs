namespace ProgrammingBasics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NestedConditionalStatementsExercise
    {
        public static void Tasks()
        {
            //P01PointOnRectangleBorder();
            //P02Cinema();
            //P03SummerOutfit();
            //P04NewHouse();
            //P05FishingBoat();
            //P06Volleyball();
            //P07Journey();
            //P08OperationsBetweenNumbers();
            //P09HotelRoom();
            P10OnTimeForTheExam();
        }

        private static void P01PointOnRectangleBorder()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool firstCond = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool secondCond = (y == y1 || y == y2) && (x >= x1 && x <= x2);
            if (firstCond || secondCond)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }

        private static void P02Cinema()
        {
            string screening = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int places = rows * columns;
            double ticketPrice = 0;
            switch (screening)
            {
                case "premiere":
                    ticketPrice = 12;
                    break;
                case "normal":
                    ticketPrice = 7.5;
                    break;
                case "discount":
                    ticketPrice = 5;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{places * ticketPrice:F2} leva");
        }

        private static void P03SummerOutfit()
        {

            int degrees = int.Parse(Console.ReadLine());
            string timeInterval = Console.ReadLine().ToLower();
            string outfit = "Shirt";
            string shoes = "Moccasins";
            switch (timeInterval)
            {
                case "morning":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }

        private static void P04NewHouse()
        {
            string typeFloweers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceFlower = 0;
            double discount = 0;
            switch (typeFloweers)
            {
                case "Roses":
                    priceFlower = 5;
                    if (numFlowers > 80)
                    {
                        discount = 0.1;
                    }
                    break;
                case "Dahlias":
                    priceFlower = 3.80;
                    if (numFlowers > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    priceFlower = 2.80;
                    if (numFlowers > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    priceFlower = 3;
                    if (numFlowers < 120)
                    {
                        discount = -0.15;
                    }
                    break;
                case "Gladiolus":
                    priceFlower = 2.50;
                    if (numFlowers < 80)
                    {
                        discount = -0.2;
                    }
                    break;
                default:
                    break;
            }
            double totalPrice = (numFlowers * priceFlower) - (numFlowers * priceFlower * discount);
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {typeFloweers} and {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
            }
        }

        private static void P05FishingBoat()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double shipPrice = 0;
            double discount = 0;
            double specialDiscount = 0;
            if (fishermen % 2 == 0)
            {
                specialDiscount = 0.05;
            }
            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Summer":
                    shipPrice = 4200;
                    break;
                case "Autumn":
                    shipPrice = 4200;
                    specialDiscount = 0;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
                default:
                    break;
            }
            if (fishermen <= 6)
            {
                discount = 0.1;
            }
            else if (fishermen > 6 && fishermen <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }
            double totalPrice = shipPrice - (shipPrice * discount);
            totalPrice -= totalPrice * specialDiscount;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva.");
            }
        }

        private static void P06Volleyball()
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double leapBonus = 0;
            if (year == "leap")
            {
                leapBonus = 0.15;
            }
            double sofiaPlays = (((48 - h) * 3.0 / 4) + (p * 2.0 / 3));
            double playDays = (sofiaPlays + h) + (sofiaPlays + h) * leapBonus;
            Console.WriteLine($"{Math.Floor(playDays)}");
        }

        private static void P07Journey()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string country = "";
            string staysIn = "";
            if (budget <= 100)
            {
                country = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.3;
                    staysIn = "Camp";
                }
                else
                {
                    budget *= 0.7;
                    staysIn = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                country = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.4;
                    staysIn = "Camp";
                }
                else
                {
                    budget *= 0.8;
                    staysIn = "Hotel";
                }
            }
            else
            {
                country = "Europe";
                staysIn = "Hotel";
                budget *= 0.9;
            }
            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{staysIn} - {budget:F2}");
        }

        private static void P08OperationsBetweenNumbers()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            string isEven = "odd";
            switch (operation)
            {
                case '+':
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        isEven = "even";
                    }
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {isEven}");
                    break;
                case '-':
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        isEven = "even";
                    }
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {isEven}");
                    break;
                case '*':
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        isEven = "even";
                    }
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {isEven}");
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = (double)n1 / n2;
                        Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} {operation} {n2} = {result}");
                    }
                    break;
                default:
                    break;
            }
        }

        private static void P09HotelRoom()
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double apartmentPrice = 0;
            double studioPrice = 0;
            switch (month)
            {
                case "May":
                case "October":
                    apartmentPrice = 65;
                    studioPrice = 50;
                    if (days > 7 && days <= 14)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    else if (days > 14)
                    {
                        studioPrice -= studioPrice * 0.3;
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                case "June":
                case "September":
                    apartmentPrice = 68.7;
                    studioPrice = 75.2;
                    if (days > 14)
                    {
                        studioPrice -= studioPrice * 0.2;
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    apartmentPrice = 77;
                    studioPrice = 76;
                    if (days > 14)
                    {
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Apartment: {days * apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {days * studioPrice:F2} lv.");
        }

        private static void P10OnTimeForTheExam()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivelHour = int.Parse(Console.ReadLine());
            int arrivelMinute = int.Parse(Console.ReadLine());
            string arrivelStatus = "";
            int examTime = examHour * 60 + examMinute;
            int arrivelTime = arrivelHour * 60 + arrivelMinute;
            if ((examTime - arrivelTime) == 0)
            {
                Console.WriteLine("On time");
            }
            else if ((examTime - arrivelTime) > 0 && (examTime - arrivelTime) <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{examTime - arrivelTime} minutes before the start");
            }
            else if ((examTime - arrivelTime) < 0)
            {
                Console.WriteLine("Late");
                if ((arrivelTime - examTime) > 59)
                {
                    int lateTime = arrivelTime - examTime;
                    int lateHour = lateTime / 60;
                    int lateMinute = lateTime % 60;
                    Console.WriteLine($"{lateHour}:{lateMinute:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{arrivelTime - examTime} minutes after the start");
                }

            }
            else
            {
                Console.WriteLine("Early");
                if ((examTime - arrivelTime) > 59)
                {
                    int earlyTime = examTime - arrivelTime;
                    int earlyHour = earlyTime / 60;
                    int earlyMinute = earlyTime % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMinute:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{examTime - arrivelTime} minutes before the start");
                }
                
            }
        }
    }
}
