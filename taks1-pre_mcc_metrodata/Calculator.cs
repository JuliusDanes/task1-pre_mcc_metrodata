using System;

namespace ConsoleExcercise
{
    class Calculator
    {
        int num1, num2, result;

        public static void Calc()
        {
            Console.Clear();
            int a, b, choice;
            Console.WriteLine("------ Calculator Mini ------");
            Console.WriteLine("Input first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Choose your operator choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            Calculator Obj = new Calculator(a, b);
            switch (choice)
            {
                case 1:
                    Obj.Addition();
                    break;
                case 2:
                    Obj.Subtraction();
                    break;
                case 3:
                    Obj.Multiplication();
                    break;
                case 4:
                    Obj.Division();
                    break;
            }
            Console.ReadKey();
        }

        public Calculator(int x, int y)
        {
            num1 = x;
            num2 = y;
        }

        public void Addition()
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }

        public void Subtraction()
        {
            result = num1 - num2;
            Console.WriteLine(result);
        }

        public void Multiplication()
        {
            result = num1 * num2;
            Console.WriteLine(result);

        }
        public void Division()
        {
            result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
