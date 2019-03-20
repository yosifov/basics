namespace ProgrammingBasics
{
    using System;

    public class ForLoopLab
    {
        public static void Tasks()
        {
            //P01NumbersFrom1to100();
            //P02LatinLetters();
            //P03SumNumbers();
            //P04MaxNumber();
            //P05MinNumber();
            //P06LeftAndRightSum();
            //P07OddEvenSum();
            //P08VowelsSum();
            P09CleverLily();
        }

        private static void P01NumbersFrom1to100()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void P02LatinLetters()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void P03SumNumbers()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }

        private static void P04MaxNumber()
        {
            int num = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }

        private static void P05MinNumber()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }

        private static void P06LeftAndRightSum()
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    sumLeft += num;
                }
                else
                {
                    sumRight += num;
                }
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }

        private static void P07OddEvenSum()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }
        }

        private static void P08VowelsSum()
        {
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }

        private static void P09CleverLily()
        {
            int years = int.Parse(Console.ReadLine());
            double washPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0;
            int toys = 0;
            int counter = 1;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10 * counter - 1;
                    counter++;
                }
                else
                {
                    toys += 1;
                }
            }
            double savedMoney = toys * toyPrice + money;
            if (savedMoney >= washPrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washPrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washPrice - savedMoney:F2}");
            }
        }
    }
}
