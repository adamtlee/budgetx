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

            Payments payments = config.GetRequiredSection("Payments").Get<Payments>();
            Income income = config.GetRequiredSection("Income").Get<Income>();

            CalculateIncomeService calculateIncomeService = new CalculateIncomeService();
            CalculatePaymentsService calculatePaymentsService = new CalculatePaymentsService();




            var monthlyIncome = calculateIncomeService.monthlyIncome(income);
            var biWeeklyIncome = calculateIncomeService.biWeeklyIncome(income);
            var baseMonthlyPayments = calculatePaymentsService.totalMonthlyPayments(payments); 
            var remainingBalance = monthlyIncome - baseMonthlyPayments;

            Console.WriteLine(income.Salary);
            Console.WriteLine($"Monthly Income: {monthlyIncome}");
            Console.WriteLine($"Bi-Weekly Income: {biWeeklyIncome}");
            Console.WriteLine($"Base Monthly Payments: {baseMonthlyPayments}");
            Console.WriteLine($"Remaining Balance: {remainingBalance}");


        }
    }
}