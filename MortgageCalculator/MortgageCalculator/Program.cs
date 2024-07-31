// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        // Input
        Console.Write("How much are you borrowing? ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("What is your interest rate? ");
        double yearlyInterestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("How long is your loan (in years)? ");
        int loanTermYears = Convert.ToInt32(Console.ReadLine());

        // Calculations
        double monthlyInterestRate = yearlyInterestRate / 1200; // Convert to monthly and decimal
        int numberOfPayments = loanTermYears * 12;

        // Calculate monthly payment
        double monthlyPayment = amount *
            (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments)) /
            (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

        // Output
        Console.WriteLine($"\nYour estimated payment is {monthlyPayment:C}");
    }
}