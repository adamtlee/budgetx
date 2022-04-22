using Budgetx.Services;
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

            CalculatePaymentsService calculatePaymentsService = new CalculatePaymentsService();

           
            Income income = config.GetRequiredSection("Income").Get<Income>();

            var monthlyIncome = income.Salary / 12;
            var biWeeklyIncome = monthlyIncome / 2;
            var baseMonthlyPayments = calculatePaymentsService.totalPayments(); 
            var remainingBalance = monthlyIncome - baseMonthlyPayments;

            Console.WriteLine(income.Salary);
            Console.WriteLine($"Monthly Income: {monthlyIncome}");
            Console.WriteLine($"Bi-Weekly Income: {biWeeklyIncome}");
            Console.WriteLine($"Base Monthly Payments: {baseMonthlyPayments}");
            Console.WriteLine($"Remaining Balance: {remainingBalance}");


        }

        public decimal CalculateBasePayment(Payments payments, Income income)
        {
            return 0; 
        }
    }
}