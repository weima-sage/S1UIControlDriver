using System;
using ControlTester.Models;
using System.Collections.ObjectModel;

namespace ControlTester.Factories
{
    public static class ExpenseFactory
    {
        public static ObservableCollection<Expense> CreateExpenses(int numExpenses)
        {
            var entities = new ObservableCollection<Expense>();
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
