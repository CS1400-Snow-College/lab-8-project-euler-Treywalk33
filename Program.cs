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
}