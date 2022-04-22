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

            Console.WriteLine(payments.Rent);
            Console.WriteLine(income.Salary);


        }

        public decimal CalculateBasePayment(Payments payments, Income income)
        {
            return 0; 
        }
    }
}