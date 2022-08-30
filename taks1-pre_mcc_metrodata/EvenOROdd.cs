using System;

namespace ConsoleExcercise
{
    class EvenOROdd
    {
        //Ex 2
        public static void EvenOrOdd()
        {
            Console.Clear();
            Console.WriteLine("Input number : ");
            int Inp = Convert.ToInt32(Console.ReadLine());
            if ((Inp % 2) == 0)
            {
                Console.WriteLine("Input number is Even");
            }
            else
            {
                Console.WriteLine("Input number is Odd");
            }
            Console.ReadKey();
        }
    }
}
