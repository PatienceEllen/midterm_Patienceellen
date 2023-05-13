using System;

namespace Palindrome
{
    class Program
    {

        public static bool IsPalindrome(string input)
        {
            // Clean up the input string by removing whitespace, punctuation, and converting to lowercase
            string cleanedInput = new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            // Add each character in the cleaned input string to the stack and the queue
            foreach (char c in cleanedInput)
            {
                stack.Push(c);
                queue.Enqueue(c);
            }

            // Remove each character from the stack and the queue in the natural order and compare
            while (stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a word or phrase: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The text you entered is a palindrome!");
            }
            else
            {
                Console.WriteLine("The text you entered is NOT a palindrome.");
            }
        }

    }

}
