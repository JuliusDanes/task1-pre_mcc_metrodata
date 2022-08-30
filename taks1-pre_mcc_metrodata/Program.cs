using System;

namespace ConsoleExcercise
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            int choice;
            Console.Clear();
            Console.WriteLine("1. Vowel OR Consonant");
            Console.WriteLine("2. Even OR Odd");
            Console.WriteLine("3. Calculator");
            Console.WriteLine("4. Greatest");
            Console.WriteLine("5. Factorial");
            Console.WriteLine("6. Prime Numbers");
            Console.WriteLine("7. Palindrome Check");
            Console.WriteLine("Enter your choice :");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    VowelORConsonant.VOrC();
                    Main();
                    break;
                case 2:
                    EvenOROdd.EvenOrOdd();
                    Main();
                    break;
                case 3:
                    Calculator.Calc();
                    Main();
                    break;
                case 4:
                    Greatest.GreatestNum();
                    Main();
                    break;
                case 5:
                    Factorial.Factor();
                    Main();
                    break;
                case 6:
                    PrimeNumbers.PrimeNum();
                    Main();
                    break;
                case 7:
                    PalindromeCheck.PalindromeMain();
                    Main();
                    break;
                default:
                    Main();
                    break;
            }

            Console.ReadKey();
        }
    }
}
