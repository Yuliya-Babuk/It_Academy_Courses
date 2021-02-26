using System;
using System.Linq;

namespace LoanCalculator
{
    class Program
    {
        private const decimal MinLoan = 100;
        private const decimal MaxLoan = 1000000;
        private static decimal[] interestRates = new[] { 5m, 10, 15 };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the best bank of Belarus!\nYou made a right choice by collaborating with us!\n\n" +
                $"Please, enter the desirable loan amount in the range from {MinLoan} to {MaxLoan} BYN");

            decimal loanAmount = ProcessInputLoanAmount();

            Console.WriteLine($"Please, enter the desirable interest rate, %: {string.Join(", ", interestRates)}");

            decimal interestRate = ProcessInputInterest();

            Console.WriteLine($"Congatulations! Your loan is {loanAmount} BYN at {interestRate}%" +
                $" per annum with differentiated payments\n");

            decimal repaidLoan = 0;
            decimal totalAmount = 0;
            const int termLoan = 12;

            for (int i = 1; i <= termLoan; i++)
            {
                decimal loanBody = Math.Round((loanAmount / termLoan), 2);
                repaidLoan += loanBody;
                decimal monthInterest = Math.Round((loanAmount - repaidLoan) * interestRate / 100 / termLoan, 2);
                decimal monthPayment = loanBody + monthInterest;
                Console.WriteLine($"{i} month payment = {monthPayment}BYN\n");
                totalAmount += monthPayment;
            }
            Console.WriteLine($"Total amount to be repaid = {totalAmount}BYN\n");
        }

        private static decimal ProcessInputLoanAmount()
        {
            decimal result;

            while (!decimal.TryParse(Console.ReadLine(), out result) || (result < MinLoan || result > MaxLoan))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            return result;
        }

        private static decimal ProcessInputInterest()
        {
            decimal result;

            while (!decimal.TryParse(Console.ReadLine(), out result) || !interestRates.Contains(result))
            {
                Console.WriteLine("Invalid input, please try again");
            }

            return result;
        }
    }
}


