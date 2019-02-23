namespace ProgrammingBasics
{
    using System;

    public class NestedConditionalStatementsLab
    {
        public static void Tasks()
        {
            //P01PersonalTitles();
            //P02SmallShop();
            //P03PointInRectangle();
            //P04FruitOrVegetable();
            //P05InvalidNumber();
            //P06FruitShop();
            //P07TradeCommissions();
            P08SkiTrip();
        }

        private static void P01PersonalTitles()
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            switch (gender)
            {
                case "m":
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else
                    {
                        Console.WriteLine("Master");
                    }
                    break;
                case "f":
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                    break;
                default:
                    break;
            }
        }

        private static void P02SmallShop()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double productPrice = 0;
            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.50;
                            break;
                        case "water":
                            productPrice = 0.80;
                            break;
                        case "beer":
                            productPrice = 1.20;
                            break;
                        case "sweets":
                            productPrice = 1.45;
                            break;
                        case "peanuts":
                            productPrice = 1.60;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.40;
                            break;
                        case "water":
                            productPrice = 0.70;
                            break;
                        case "beer":
                            productPrice = 1.15;
                            break;
                        case "sweets":
                            productPrice = 1.30;
                            break;
                        case "peanuts":
                            productPrice = 1.50;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.45;
                            break;
                        case "water":
                            productPrice = 0.70;
                            break;
                        case "beer":
                            productPrice = 1.10;
                            break;
                        case "sweets":
                            productPrice = 1.35;
                            break;
                        case "peanuts":
                            productPrice = 1.55;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(productPrice * quantity);
        }

        private static void P03PointInRectangle()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= x1 && y >= y1)
            {
                if (x <= x2 && y <= y2)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }

        private static void P04FruitOrVegetable()
        {
            string product = Console.ReadLine();
            if (product == "banana" ||
                product == "apple" ||
                product == "kiwi" ||
                product == "cherry" ||
                product == "lemon" ||
                product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" ||
                     product == "cucumber" ||
                     product == "pepper" ||
                     product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }

        private static void P05InvalidNumber()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || (number > 0 && number < 100) || number > 200)
            {
                Console.WriteLine("invalid");
            }
        }

        private static void P06FruitShop()
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double productPrice = 0;
            switch (day)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    switch (fruit)
                    {
                        case "banana":
                            productPrice = 2.50;
                            break;
                        case "apple":
                            productPrice = 1.20;
                            break;
                        case "orange":
                            productPrice = 0.85;
                            break;
                        case "grapefruit":
                            productPrice = 1.45;
                            break;
                        case "kiwi":
                            productPrice = 2.70;
                            break;
                        case "pineapple":
                            productPrice = 5.50;
                            break;
                        case "grapes":
                            productPrice = 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "saturday":
                case "sunday":
                    switch (fruit)
                    {
                        case "banana":
                            productPrice = 2.70;
                            break;
                        case "apple":
                            productPrice = 1.25;
                            break;
                        case "orange":
                            productPrice = 0.90;
                            break;
                        case "grapefruit":
                            productPrice = 1.60;
                            break;
                        case "kiwi":
                            productPrice = 3.00;
                            break;
                        case "pineapple":
                            productPrice = 5.60;
                            break;
                        case "grapes":
                            productPrice = 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (productPrice > 0)
            {
                Console.WriteLine($"{productPrice * quantity:F2}");
            }
        }

        private static void P07TradeCommissions()
        {
            string city = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine());
            double commission = 0;
            switch (city)
            {
                case "sofia":
                    if (sells >= 0 && sells <= 500)
                    {
                        commission = 0.05;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commission = 0.07;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commission = 0.08;
                    }
                    else if (sells > 10000)
                    {
                        commission = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "varna":
                    if (sells >= 0 && sells <= 500)
                    {
                        commission = 0.045;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commission = 0.075;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commission = 0.10;
                    }
                    else if (sells > 10000)
                    {
                        commission = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "plovdiv":
                    if (sells >= 0 && sells <= 500)
                    {
                        commission = 0.055;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commission = 0.08;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commission = 0.12;
                    }
                    else if (sells > 10000)
                    {
                        commission = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (commission > 0)
            {
                Console.WriteLine($"{sells * commission:F2}");
            }
        }

        private static void P08SkiTrip()
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string room = Console.ReadLine().ToLower();
            string review = Console.ReadLine().ToLower();
            double discount = 0;
            double roomPrice = 18;
            switch (room)
            {
                case "apartment":
                    if (days < 10)
                    {
                        discount = 0.3;
                        roomPrice = 25;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                        roomPrice = 25;
                    }
                    else
                    {
                        discount = 0.5;
                        roomPrice = 25;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        discount = 0.1;
                        roomPrice = 35;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                        roomPrice = 35;
                    }
                    else
                    {
                        discount = 0.2;
                        roomPrice = 35;
                    }
                    break;
                default:
                    break;
            }
            double totalPrice = (days * roomPrice) - (days * roomPrice * discount);
            if (review == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice * 0.10;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
