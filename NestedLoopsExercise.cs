namespace ProgrammingBasics
{
    using System;

    public class NestedLoopsExercise
    {
        public static void Tasks()
        {
            //P01Matrix();
            //P02NumberPyramid();
            //P03Coding();
            //P04EqualSumsEvenOddPosition();
            //P05EqualSumsLeftRightPosition();
            //P06SumPrimeNonPrime();
            P07TrainTheTrainers();
        }

        private static void P01Matrix()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            for (int num1 = a; num1 <= b; num1++)
            {
                for (int num2 = a; num2 <= b; num2++)
                {
                    for (int num3 = c; num3 <= d; num3++)
                    {
                        for (int num4 = c; num4 <= d; num4++)
                        {
                            if ((num1 + num4) == (num2 + num3) && (num1 != num2) && (num3 != num4))
                            {
                                Console.WriteLine($"{num1}{num2}");
                                Console.WriteLine($"{num3}{num4}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }

        private static void P02NumberPyramid()
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }

        private static void P03Coding()
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n.ToString().Length;
            int newNumber = n;
            for (int i = 1; i <= rows; i++)
            {
                int number = newNumber % 10;
                if (number == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    for (int j = 1; j <= number; j++)
                    {
                        Console.Write(Convert.ToChar(number + 33));
                    }
                    Console.WriteLine();
                }
                newNumber /= 10;
            }

        }

        private static void P04EqualSumsEvenOddPosition()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 0; j < i.ToString().Length; j += 2)
                {
                    string oddIndexNumber = i.ToString()[j].ToString();
                    sumOdd += int.Parse(oddIndexNumber);
                }
                for (int k = 1; k <= i.ToString().Length; k += 2)
                {
                    string evenIndexNumber = i.ToString()[k].ToString();
                    sumEven += int.Parse(evenIndexNumber);
                }
                if (sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
                sumOdd = 0;
                sumEven = 0;
            }
        }

        private static void P05EqualSumsLeftRightPosition()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    sumLeft += int.Parse(i.ToString()[j].ToString());
                }
                for (int k = i.ToString().Length - 1; k >= i.ToString().Length - 2; k--)
                {
                    sumRight += int.Parse(i.ToString()[k].ToString());
                }
                if (sumLeft == sumRight)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    if (sumLeft > sumRight)
                    {
                        sumRight += int.Parse(i.ToString()[2].ToString());
                    }
                    else
                    {
                        sumLeft += int.Parse(i.ToString()[2].ToString());
                    }
                    if (sumLeft == sumRight)
                    {
                        Console.Write(i + " ");
                    }
                }
                sumLeft = 0;
                sumRight = 0;
            }
        }

        private static void P06SumPrimeNonPrime()
        {
            string command = Console.ReadLine();
            int sumPrime = 0;
            int sumNotPrime = 0;
            while (command != "stop")
            {
                int num = int.Parse(command);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    if (num == 1)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                    {
                        sumPrime += num;
                    }
                    else
                    {
                        sumNotPrime += num;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");
        }

        private static void P07TrainTheTrainers()
        {
            int n = int.Parse(Console.ReadLine());
            string subject = Console.ReadLine();
            double finalAssessment = 0;
            int counter = 0;
            while (subject != "Finish")
            {
                double gradeSum = 0;

                for (int j = 1; j <= n; j++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    finalAssessment += grade;
                    counter++;
                }
                Console.WriteLine($"{subject} - {gradeSum / n:F2}.");
                subject = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {finalAssessment / counter:F2}.");
        }
    }
}
