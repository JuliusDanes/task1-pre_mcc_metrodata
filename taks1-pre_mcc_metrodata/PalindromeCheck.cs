using System;

namespace ConsoleExcercise
{
    class PalindromeCheck
    {
        public static void PalindromeMain()
        {
            Console.Clear();
            Console.Write("Enter something for to check that is it palindrome :");
            string text = Console.ReadLine();
            bool flag = true;

            flag = isPalindrome(text);
            //if flag true, text is palindrome
            if (flag)
            {
                Console.WriteLine("{0} is palindrome", text);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", text);
            }
            Console.ReadKey();
        }

        public static bool isPalindrome(string text)
        {
            Console.Clear();

            int len = text.Length;
            bool flag = true;

            //check palindrome
            for (int i = 0; i < len / 2; i++)
            {
                if (text[i] != text[len - (i + 1)])
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
