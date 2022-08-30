using System;

namespace ConsoleExcercise
{
    class Factorial
    {
        public static void Factor()
        {
            Console.Clear();
            int Inp;
            Console.WriteLine("----- Factorial -----\n");

            Console.WriteLine("Please input number : ");
            Inp = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            for (int i = 1; i <= count; i++)
            {
                if (Inp > 20)
                {
                    count *= i;
                }
                else
                {
                    Console.WriteLine("Your input number more than 21");
                    Console.WriteLine("Please input in range number (1-20)");
                    break;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
