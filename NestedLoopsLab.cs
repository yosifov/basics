namespace ProgrammingBasics
{
    using System;

    public class NestedLoopsLab
    {
        public static void Tasks()
        {
            //P01NumbersFromNToOne();
            //P02NumbersFromOneToNWithStepThree();
            //P03EvenPowersOfTwo();
            //P04Combination();
            //P05Building();
            //P06Travelling();
            //P07NameWars();
            P08CookieFactory();
        }

        private static void P01NumbersFromNToOne()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void P02NumbersFromOneToNWithStepThree()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static void P03EvenPowersOfTwo()
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(current);
                current = current * 4;
            }
        }

        private static void P04Combination()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int x1 = 0; x1 <= n; x1++)
            {
                for (int x2 = 0; x2 <= n; x2++)
                {
                    for (int x3 = 0; x3 <= n; x3++)
                    {
                        for (int x4 = 0; x4 <= n; x4++)
                        {
                            for (int x5 = 0; x5 <= n; x5++)
                            {
                                if (x1 + x2 + x3 + x4 + x5 == n)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }

        private static void P05Building()
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            for (int i = floors; i >= 1; i--)
            {
                for (int j = 0; j < flats; j++)
                {
                    if (i == floors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                if (floors == 1)
                {
                    break;
                }
                Console.WriteLine();
            }
        }

        private static void P06Travelling()
        {
            string destination = Console.ReadLine();
            double currentBudget = 0;
            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                while (currentBudget < minBudget)
                {
                    double amount = double.Parse(Console.ReadLine());
                    currentBudget += amount;
                }
                Console.WriteLine($"Going to {destination}!");
                currentBudget = 0;
                destination = Console.ReadLine();
            }
        }

        private static void P07NameWars()
        {
            int maxSum = int.MinValue;
            string winner = "";
            string name = Console.ReadLine();
            while (name != "STOP")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    winner = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winner} - {maxSum}!");
        }

        private static void P08CookieFactory()
        {
            int numBatches = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numBatches; i++)
            {
                bool containsFlour = false;
                bool containsEggs = false;
                bool containsSugar = false;
                string ingredient = Console.ReadLine();
                while (!(containsFlour && containsEggs && containsSugar))
                {
                    if (ingredient == "flour")
                    {
                        containsFlour = true;
                    }
                    else if (ingredient == "eggs")
                    {
                        containsEggs = true;
                    }
                    else if (ingredient == "sugar")
                    {
                        containsSugar = true;
                    }
                    else if (ingredient == "Bake!")
                    {
                        if (containsFlour && containsEggs && containsSugar)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    ingredient = Console.ReadLine();
                }
                Console.WriteLine($"Baking batch number {i}...");
            }
            // TODO
        }
    }
}
