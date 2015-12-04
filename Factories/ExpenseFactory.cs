using System;
using ControlTester.Models;
using System.Collections.Generic;

namespace ControlTester.Factories
{
    public static class ExpenseFactory
    {
        public static IList<Expense> CreateExpenses(int numExpenses)
        {
            var entities = new List<Expense>();
            Random rnd = new Random();
            for(int i = 1; i < numExpenses + 1; ++i)
            {
                entities.Add(new Expense { 
                    ContactName = "Contact name", 
                    CompanyName = "Company name",
                    Amount = (rnd.Next(100000) / 100m),
                });
            }

            return entities;
        }
    }
}
