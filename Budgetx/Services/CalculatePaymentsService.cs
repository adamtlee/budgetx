using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgetx.Services
{
    public class CalculatePaymentsService
    {
        IConfiguration config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .AddEnvironmentVariables()
               .Build();

        
        public decimal totalPayments()
        {
            Payments payments = config.GetRequiredSection("Payments").Get<Payments>();
            return payments.Rent + payments.Loans + payments.Subscriptions + payments.Investments + payments.DogExpenses + payments.Food;
        }
    }
}
