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
        public decimal totalMonthlyPayments(Payments payments)
        {
            return payments.Rent + payments.Loans + payments.Subscriptions + payments.Investments + payments.DogExpenses + payments.Food;
        }
    }
}
