// Trey Walker, 12-8-24, Euler

using System; 
namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler Solver");

            while (true)
            {
                Console.WriteLine("Choose a problem:");
                Console.WriteLine("1. Multiples of 3 and 5");
                Console.WriteLine("2. Even Fibonacci Numbers");
                Console.WriteLine("3. Largest Prime Factor");
                Console.WriteLine("4. Largest Palindrome Product");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result: " + MultiplesOf3And5(1000));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + EvenFibonacciNumbers(4000000));
                        break;
                    case 3:
                        Console.WriteLine("Result: " + LargestPrimeFactor(600851475143));
                        break;
                    case 4:
                        Console.WriteLine("Result: " + LargestPalindromeProduct());
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static int MultiplesOf3And5(int limit)
        {
            int sum = 0;
            for (int i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static int EvenFibonacciNumbers(int limit)
        {
            int a = 1, b = 2, sum = 0;
            while (b <= limit)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                }
                int temp = b;
                b = a + b;
                a = temp;
            }
            return sum;
        }

        static long LargestPrimeFactor(long number)
        {
            long largestFactor = 1;
            while (number % 2 == 0)
            {
                largestFactor = 2;
                number /= 2;
            }

            for (long i = 3; i * i <= number; i += 2)
            {
                while (number % i == 0)
                {
                    largestFactor = i;
                    number /= i;
                }
            }

            if (number > 1)
                largestFactor = number;

            return largestFactor;
        }

        static int LargestPalindromeProduct()
        {
            int largestPalindrome = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    if (product > largestPalindrome && IsPalindrome(product))
                    {
                        largestPalindrome = product;
                    }
                }
            }
            return largestPalindrome;
        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int length = numberString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (numberString[i] != numberString[length- i - 1])
                {
                    return false;
                }
            }
            return true;

        }
    }
}