using System;

namespace ConsoleExcercise
{
    class VowelORConsonant
    {
        //Ex 1
        public static void VOrC()
        {
            Console.Clear();
            Console.WriteLine("Input character : ");
            string Inp = Console.ReadLine();
            if (Inp == "a" || Inp == "i" || Inp == "u" || Inp == "e" || Inp == "o")
            {
                Console.WriteLine("Input character is Vowel");
            }
            else
            {
                Console.WriteLine("Input character is Consonant");
            }
            Console.ReadKey();
        }
    }
}
