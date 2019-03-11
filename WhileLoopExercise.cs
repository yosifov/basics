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
            P03Vacation();
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

        }
    }
}
