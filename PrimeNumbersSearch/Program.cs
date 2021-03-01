using System;

namespace PrimeNumbersSearch
{
    class Program

        // first oprion - my
    {
        static void Main(string[] args)

        {
            int n;

            Console.WriteLine("Please enter any number > 0");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error! Please enter number > 0");
            }

            Console.Write("Prime numbers: 1\t");

            switch (n)
            {
                case 1:
                    break;
                case 2:
                    Console.Write("{0}", n);
                    break;
                default:
                    Console.Write("2\t");
                    if (n <= 0)
                    {
                        Console.WriteLine("Error! Please enter number > 0");
                    }
                    else
                    {
                        int i = 3;
                        while (i <= n)
                        {
                            int j = 2;
                            while (j <= i - 1)
                            {
                                if (i % j == 0)

                                    break;

                                j++;
                            }

                            if (j == i)

                                Console.Write(i + "\t");

                            i++;
                        }
                    }
                    break;
            }

            // second option, do not understand clearly with Sqrt

            Console.WriteLine("\nPlease enter any number > 0");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error! Please enter number > 0");
            }
            for (int j = 2; j <= n; j++)
            {

                bool isPrime = IsPrime(j);

                if (isPrime)
                {
                    Console.WriteLine($"{j} is Prime");
                }
            }
        }
        private static bool IsPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}