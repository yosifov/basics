using System;

namespace ProgrammingBasics
{
    class FirstSpetsInCoding
    {
        public static void Tasks()
        {
            //P01HelloSoftUni();
            //P02Expression();
            //P03Nums();
            P04AreaOfTriangle();
        }

        private static void P01HelloSoftUni()
        {
            Console.WriteLine("Hello SoftUni");
        }

        private static void P02Expression()
        {
            Console.WriteLine((3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3);
        }

        private static void P03Nums()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void P04AreaOfTriangle()
        {
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + (a * b));
        }
    }
}
