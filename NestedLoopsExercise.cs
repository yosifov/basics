namespace ProgrammingBasics
{
    using System;

    public class NestedLoopsExercise
    {
        public static void Tasks()
        {
            //P01Matrix();
            P02NumberPyramid();
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
            
        }
    }
}
