﻿namespace ProgrammingBasics
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
            //P05TimePlus15Minutes();
            //P06ThreeBrothers();
            //P07Choreography();
            //P08WorldSwimmingRecord();
            P09Scholarship();
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
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newMinutes = minutes + 15;
            int newHours = hours;
            if (newMinutes > 59)
            {
                newMinutes -= 60;
                newHours += 1;
                if (newHours > 23)
                {
                    newHours = 24 - newHours;
                }
            }
            Console.WriteLine($"{newHours}:{newMinutes:D2}");
        }

        private static void P06ThreeBrothers()
        {
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());
            double dadTime = double.Parse(Console.ReadLine());
            double totalTime = 1 / (1 / firstTime + 1 / secondTime + 1 / thirdTime);
            double totalTimeWithRest = totalTime + (totalTime * 0.15);
            double leftTime = dadTime - totalTimeWithRest;
            Console.WriteLine($"Cleaning time: {totalTimeWithRest:F2}");
            if (leftTime >= 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(leftTime):F0} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(leftTime)):F0} hours.");
            }
        }

        private static void P07Choreography()
        {
            int numSteps = int.Parse(Console.ReadLine());
            int numDancers = int.Parse(Console.ReadLine());
            int daysLearning = int.Parse(Console.ReadLine());
            double stepsPerDay = numSteps / daysLearning;
            double percentStepsPerDay = Math.Ceiling((stepsPerDay / numSteps) * 100);
            if (percentStepsPerDay < 15)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {(percentStepsPerDay / numDancers):F2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {(percentStepsPerDay / numDancers):F2}% steps to be learned per day.");
            }
        }

        private static void P08WorldSwimmingRecord()
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            double resistence = Math.Floor((distance / 15)) * 12.5;
            double totalTime = (distance * timeForOneMeter) + resistence;
            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:F2} seconds slower.");
            }
        }

        private static void P09Scholarship()
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = Math.Floor(minSalary * 0.35);
            double gradeScholarship = Math.Floor(grade * 25);

            if (income <= minSalary)
            {
                if (grade >= 5.5)
                {
                    if (gradeScholarship >= socialScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {gradeScholarship} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                    }
                }
                else if (grade > 4.5)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else if (grade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {gradeScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
