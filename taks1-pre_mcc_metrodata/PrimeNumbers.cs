using System;

namespace ConsoleExcercise
{
    class PrimeNumbers
    {
        public static void PrimeNum()
        {
            Console.Clear();
            Console.WriteLine("----- Prime Numbers -----\n");
            Console.WriteLine("Input limit number ");
            int lim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************");

            bool isPrime = true;
            Console.WriteLine("Prime Numbers are: ");
            for (int i = 0; i <= lim; i++)
            {
                for (int n = 2; n <= lim; n++)
                {

                    if (i != n && i % n == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
