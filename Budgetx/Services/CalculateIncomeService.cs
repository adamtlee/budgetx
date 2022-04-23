using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgetx.Services
{
    public class CalculateIncomeService
    {
        public decimal monthlyIncome(Income income)
        {
            return income.Salary / 12;
        }

        public decimal biWeeklyIncome(Income income)
        {
            if (income != null)
            {
                return this.monthlyIncome(income) / 2;
            }

            return income.Salary;
            
        }
    }
}
