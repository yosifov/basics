using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingBasics
{
    public class WhileLoopExercise
    {
        public static void Tasks()
        {
            //P01OldBooks();
            //P02ExamPreparation();
            //P03Vacation();
            //P04Coins();
            P05Cake();
        }

        private static void P01OldBooks()
        {
            string serchedBook = Console.ReadLine();
            int numBooks = int.Parse(Console.ReadLine());
            int counter = 0;
            bool founded = false;
            while (counter < numBooks)
            {
                string randomBook = Console.ReadLine();
                if (randomBook == serchedBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    founded = true;
                    break;
                }
                counter++;
            }
            if (!founded)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numBooks} books.");
            }
        }

        private static void P02ExamPreparation()
        {
            int badEvaluations = int.Parse(Console.ReadLine());
            int counter = 0;
            int problems = 0;
            double score = 0;
            string lastProblem = "";
            string taskName = Console.ReadLine();
            while (counter < badEvaluations)
            {
                if (taskName == "Enough")
                {
                    break;
                }
                else
                {
                    lastProblem = taskName;
                    double taskEval = double.Parse(Console.ReadLine());
                    if (taskEval <= 4.00)
                    {
                        counter++;
                    }
                    score += taskEval;
                    problems++;
                    taskName = Console.ReadLine();
                }

            }
            if (counter < badEvaluations)
            {
                Console.WriteLine($"Average score: {score / problems:F2}");
                Console.WriteLine($"Number of problems: {problems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {counter} poor grades.");
            }

        }

        private static void P03Vacation()
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            
            int spendCounter = 0;
            int days = 0;
            while (availableMoney < neededMoney && spendCounter < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                switch (action)
                {
                    case "spend":
                        availableMoney -= amount;
                        spendCounter++;
                        break;
                    case "save":
                        availableMoney += amount;
                        spendCounter = 0;
                        break;
                    default:
                        break;
                }
                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }
                days++;
            }
            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }

        private static void P04Coins()
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int counter = 0;
            while (change > 0)
            {
                if (change >= 2m)
                {
                    change -= 2.0m;
                    counter++;
                }
                else if (change >= 1m)
                {
                    change -= 1.0m;
                    counter++;
                }
                else if (change >= 0.5m)
                {
                    change -= 0.5m;
                    counter++;
                }
                else if (change >= 0.2m)
                {
                    change -= 0.2m;
                    counter++;
                }
                else if (change >= 0.1m)
                {
                    change -= 0.1m;
                    counter++;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                    counter++;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                    counter++;
                }
                else if (change >= 0.01m)
                {
                    change -= 0.01m;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        private static void P05Cake()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakeArea = width * length;
            int counter = 0;
            while (cakeArea >= 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeArea} pieces are left.");
                    break;
                }
                cakeArea -= int.Parse(input);
                counter++;
            }
            if (cakeArea < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
            }
        }
    }
}
