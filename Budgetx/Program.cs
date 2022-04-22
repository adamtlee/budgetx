using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Models;
using System;

namespace Budgetx 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            Payments payments = config.GetRequiredSection("Payments").Get<Payments>();
            Income income = config.GetRequiredSection("Income").Get<Income>();

            var monthlyIncome = income.Salary / 12;
            var baseMonthlyPayments = payments.Rent + payments.Loans + payments.Subscriptions + payments.Investments;
            var remainingBalance = monthlyIncome - baseMonthlyPayments;

            Console.WriteLine(payments.Rent);
            Console.WriteLine(income.Salary);
            Console.WriteLine($"Monthly Income: {monthlyIncome}");
            Console.WriteLine($"Base Monthly Payments: {baseMonthlyPayments}");
            Console.WriteLine($"Remaining Balance: {remainingBalance}");


        }

        public decimal CalculateBasePayment(Payments payments, Income income)
        {
            return 0; 
        }
    }
}