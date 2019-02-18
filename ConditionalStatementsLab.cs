namespace ProgrammingBasics
{
    using System;

    public class ConditionalStatementsLab
    {
        public static void Tasks()
        {
            //P01ExcellentResult();
            //P02GreaterNumber();
            //P03EvenOrOdd();
            //P04NumberOneToNineToText();
            //P05ThreeEqualNumbers();
            //P06Number100To200();
            //P07PasswordGuess();
            //P08EqualWords();
            //P09AreaOfFigures();
            //P10DayOfWeek();
            //P11AnimalType();
            P12ToyShop();
        }

        private static void P01ExcellentResult()
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent!");
            }
        }

        private static void P02GreaterNumber()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }

        private static void P03EvenOrOdd()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        private static void P04NumberOneToNineToText()
        {
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("number too big");
                    break;
            }
        }

        private static void P05ThreeEqualNumbers()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                if (firstNumber == thirdNumber)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static void P06Number100To200()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }

        private static void P07PasswordGuess()
        {
            string password = Console.ReadLine();
            string realPassword = "s3cr3t!P@ssw0rd";
            if (password == realPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }

        private static void P08EqualWords()
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();
            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static void P09AreaOfFigures()
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "square":
                    double sqA = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{sqA * sqA:F3}");
                    break;
                case "rectangle":
                    double rectA = double.Parse(Console.ReadLine());
                    double rectB = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{rectA * rectB:F3}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    double circleArea = Math.PI * radius * radius;
                    Console.WriteLine($"{circleArea:F3}");
                    break;
                case "triangle":
                    double triA = double.Parse(Console.ReadLine());
                    double triH = double.Parse(Console.ReadLine());
                    double triangleArea = (triA * triH) / 2;
                    Console.WriteLine($"{triangleArea:F3}");
                    break;
                default:
                    break;
            }
        }

        private static void P10DayOfWeek()
        {
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        private static void P11AnimalType()
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }

        private static void P12ToyShop()
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzlesNum = int.Parse(Console.ReadLine());
            int dolsNum = int.Parse(Console.ReadLine());
            int bearsNum = int.Parse(Console.ReadLine());
            int minionsNum = int.Parse(Console.ReadLine());
            int trucksNum = int.Parse(Console.ReadLine());
            int orderedToys = puzzlesNum + dolsNum + bearsNum + minionsNum + trucksNum;
            double discount = 0;
            if (orderedToys >= 50)
            {
                discount = 0.25;
            }
            double orderPrice =
                (puzzlesNum * 2.60) +
                (dolsNum * 3) +
                (bearsNum * 4.10) +
                (minionsNum * 8.20) +
                (trucksNum * 2);
            double totalMoney = orderPrice - (orderPrice * discount);
            double profitMoney = totalMoney - (totalMoney * 0.10);
            if (profitMoney >= holidayPrice)
            {
                Console.WriteLine($"Yes! {profitMoney - holidayPrice:F2} lv left.");
            } else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - profitMoney:F2} lv needed.");
            }
        }
    }
}
