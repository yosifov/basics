using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingBasics
{
    public class WhileLoopLab
    {
        public static void Tasks()
        {
            //P01NumberInRange();
            //P02Sequence2kPlusOne();
            //P03AccountBalance();
            //P04NumberSequence();
            //P05Walking();
            //P06Graduation();
            P08Moving();
        }

        private static void P01NumberInRange()
        {
            int number = int.Parse(Console.ReadLine());
            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {number}");
        }

        private static void P02Sequence2kPlusOne()
        {
            int number = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= number)
            {
                Console.WriteLine(i + " ");
                i = 2 * i + 1;
            }
        }

        private static void P03AccountBalance()
        {
            int installmentNum = int.Parse(Console.ReadLine());
            int i = 1;
            double sum = 0;
            while (i <= installmentNum)
            {
                double installment = double.Parse(Console.ReadLine());

                if (installment < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {installment:F2}");
                    sum += installment;
                }
                i++;
            }
            Console.WriteLine($"Total: {sum:F2}");
        }

        private static void P04NumberSequence()
        {
            string number = Console.ReadLine();
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            while (number != "END")
            {
                if (minNum > int.Parse(number))
                {
                    minNum = int.Parse(number);
                }
                if (maxNum < int.Parse(number))
                {
                    maxNum = int.Parse(number);
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }

        private static void P05Walking()
        {
            int goal = 10000;
            string steps = Console.ReadLine();
            int stepsCount = 0;

            while (stepsCount < goal)
            {
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    stepsCount += int.Parse(steps);
                    break;
                }
                else
                {
                    stepsCount += int.Parse(steps);
                    if (stepsCount >= goal)
                    {
                        break;
                    }
                }
                steps = Console.ReadLine();
            }
            if (stepsCount < goal)
            {
                Console.WriteLine($"{goal - stepsCount} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
            }

        }

        private static void P06Graduation()
        {
            string name = Console.ReadLine();
            double gradeTotal = 0;
            int counter = 1;
            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    gradeTotal += grade;
                    counter++;
                }
            }
            if ((gradeTotal / 12) >= 4.00)
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeTotal / 12:F2}");
            }
        }

        private static void P07GraduationPartTwo()
        {
            string name = Console.ReadLine();
            int counter = 1;
            double gradeTotal = 0;
            int failedYears = 0;
            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    failedYears++;

                    if (failedYears >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter - 1} grade");
                        break;
                    }
                }
                else
                {
                    gradeTotal += grade;
                }
                counter++;
            }
            if ((gradeTotal / 12) >= 4.00 && failedYears < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeTotal / 12:F2}");
            }
        }

        private static void P08Moving()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int capacity = width * length * height;
            while (capacity > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                capacity -= int.Parse(input);
            }
            if (capacity < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(capacity)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{capacity} Cubic meters left.");
            }
        }
    }
}
