namespace ProgrammingBasics
{
    using System;

    public class ForLoopExercise
    {
        public static void Tasks()
        {
            //P01NumbersEndingIn7();
            P02HalfSumElement();
        }

        private static void P01NumbersEndingIn7()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        private static void P02HalfSumElement()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                sum += number;
            }
            if (max == (sum - max))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - (sum - max))}");
            }
        }
    }
}
