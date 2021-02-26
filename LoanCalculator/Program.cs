using System;

namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the best bank of Belarus!\nYou made a right choice by collaborating with us!\n\n" +
                "Please, enter the desirable loan amount in the range from 100 to 1 000 000 BYN");

            decimal loanAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please, enter the desirable interest rate: 5%, 10% or 15%");

            decimal interestRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Congatulations! Your loan is {loanAmount} BYN at {interestRate}%" +
                $" per annum with differentiated payments\n");

            decimal repaidLoan = 0;
            decimal totalAmount = 0;

            for (int i = 1; i <= 12; i++)
            {
                decimal loanBody = Math.Round((loanAmount / 12), 2);
                repaidLoan = repaidLoan + loanBody;
                decimal monthInterest = Math.Round((loanAmount - repaidLoan) * interestRate / 100 / 12, 2);
                decimal monthPayment = loanBody + monthInterest;
                Console.WriteLine($"{i} month payment = {monthPayment}BYN\n");
                totalAmount = totalAmount + monthPayment;
            }
            Console.WriteLine($"Total amount to be repaid = {totalAmount}BYN\n");
        }


    }
}
