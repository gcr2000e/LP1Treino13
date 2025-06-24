using System;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var word in args)
            {
                try
                {
                    bool result = IsPalindrome(word);
                    Console.WriteLine($"{word} -> {result.ToString().ToLower()}");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine($"{word} -> erro (null)");
                }
            }
        }

        public static bool IsPalindrome(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.Length < 2)
                return true;

            // Função local para verificar palíndromo
            bool IsPalindromeRecursive(int start, int end)
            {
                if (start >= end) return true;
                if (input[start] != input[end]) return false;
                return IsPalindromeRecursive(start + 1, end - 1);
            }

            return IsPalindromeRecursive(0, input.Length - 1);
        }
    }
}
