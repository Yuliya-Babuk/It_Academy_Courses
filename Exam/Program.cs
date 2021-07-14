using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{

    class MathOperations
    {
        int FactorialValue { get; set; }
        double Pow { get; set; }
        public int FactorialCalculation(int value)
        {
            if (value < 0)
            {
                throw new Exception("Value should be positive");
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= value; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }

        }
    }
    static class IntExtension
    {
        public static string IntToString(this int number)
        {
            var charElements = number.ToString().ToCharArray();
            List<string> result = new List<string>();
            string one, two, three, four;
            foreach (var charElement in charElements)
            {
                switch (charElement)
                {
                    case '1':
                        one = "one";
                        result.Add(one);
                        break;
                    case '2':
                        two = "two";
                        result.Add(two);
                        break;
                    case '3':
                        three = "three";
                        result.Add(three);
                        break;
                    case '4':
                        four = "four";
                        result.Add(four);
                        break;
                }

            }
            string res = string.Join(" ", result);
            return res;
        }
    }
    class Program
    {
        static void Run()
        {
            int[,] array = new int[4, 4]
                 {{2,-5,4,6},
                {-7,3,9,-8},
                {9,4,-2,8},
                {-5,3,7,1}};
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {

                    array[i, j] = i < j ? 1 : array[i, j];

                    Console.Write($"{array[i, j]}      ");
                }
                Console.WriteLine();

            }
        }
        static void Run2()
        {
            int number = 1234;
            Console.WriteLine(number.IntToString());
        }
        static void Run3()
        {

            List<int> initialList = new List<int>() { 4, 5, 7, 4, 0, -7, 2, 8 };
            var resultList = initialList.OrderBy(r => r)
                .Skip((initialList.Count / 2) % 2 == 0 ? (initialList.Count()) / 2 : (initialList.Count()) / 2 + 1)
                .Reverse()
                .Select(r => r * r)
                .ToList();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Run();
            // Run2();
            // Run3();
            MathOperations fact = new MathOperations();
            int factorial = fact.FactorialCalculation(1111111111);
        }

    }
}
