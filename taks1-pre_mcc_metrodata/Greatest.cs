using System;

namespace ConsoleExcercise
{
    class Greatest
    {
        public static void GreatestNum()
        {
            Console.Clear();
            int x, y, z;
            Console.WriteLine("----- Greatest Number -----\n");
            Console.WriteLine("Input first number :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number :");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third number :");
            z = Convert.ToInt32(Console.ReadLine());

            if (x >= y && x >= z)
            {
                Console.WriteLine("The greatest number is {0}", x);
            }
            else if (y >= x && y >= z)
            {
                Console.WriteLine("The greatest number is {0}", y);
            }
            else if (z >= x && z >= y)
            {
                Console.WriteLine("The greatest number is {0}", z);
            }
            Console.ReadKey();
        }
    }
}
