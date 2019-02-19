namespace ProgrammingBasics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ConditionalStatementsExercise
    {
        public static void Tasks()
        {
            //P01SumSeconds();
            //P02BonusScore();
            //P03SpeedInfo();
            //P04MetricConverter();
            P05TimePlus15Minutes();
        }

        private static void P01SumSeconds()
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());
            int totalTime = firstPlayer + secondPlayer + thirdPlayer;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            Console.WriteLine($"{minutes}:{seconds:D2}");
        }

        private static void P02BonusScore()
        {
            double basePoints = double.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (basePoints % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (basePoints % 10 == 5)
            {
                bonusPoints += 2;
            }
            if (basePoints <= 100)
            {
                bonusPoints += 5;
            }
            else if (basePoints > 100 && basePoints <= 1000)
            {
                bonusPoints += basePoints * 0.20;
            }
            else
            {
                bonusPoints += basePoints * 0.10;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(basePoints + bonusPoints);
        }

        private static void P03SpeedInfo()
        {
            double speed = double.Parse(Console.ReadLine());
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }

        private static void P04MetricConverter()
        {
            double number = double.Parse(Console.ReadLine());
            string metricIn = Console.ReadLine();
            string metricOut = Console.ReadLine();
            double convertRate = 1;
            if (metricIn == "mm")
            {
                if (metricOut == "cm")
                {
                    convertRate = 0.1;
                }
                else if (metricOut == "m")
                {
                    convertRate = 0.001;
                }
            }
            else if (metricIn == "cm")
            {
                if (metricOut == "mm")
                {
                    convertRate = 10;
                }
                else if (metricOut == "m")
                {
                    convertRate = 0.01;
                }
            }
            else
            {
                if (metricOut == "mm")
                {
                    convertRate = 1000;
                }
                else if (metricOut == "cm")
                {
                    convertRate = 100;
                }
            }
            Console.WriteLine($"{number * convertRate:F3}");
        }

        private static void P05TimePlus15Minutes()
        {

        }
    }
}
