using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operand1:");
            var operand1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation:\n" +
                "1 - to add\n" +
                "2 - to deduct\n" +
                "3 - to multiply\n" +
                "4 - to divide");
            var operation = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter operand2:");
            var operand2 = Double.Parse(Console.ReadLine());

            try
            {
                var result = Calculator.Calculate(operand1, operand2, (OperationType)operation);
                Console.WriteLine($"Result is {result}");
            }
            catch (System.DivideByZeroException e) { Console.WriteLine(e.Message); }
            catch (System.NotImplementedException e) { Console.WriteLine(e.Message); };
        }
    }
}
