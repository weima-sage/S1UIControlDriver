using System;
using ControlTester.Models;
using System.Collections.ObjectModel;

namespace ControlTester.Factories
{
    public static class InvoiceFactory
    {
        public static ObservableCollection<Invoice> CreateInvoices(int numInvoices)
        {
            var entities = new ObservableCollection<Invoice>();
            Random rnd = new Random();
            for(int i = 1; i < numInvoices + 1; ++i)
            {
                entities.Add(new Invoice { 
                    ContactName = "Contact name", 
                    CompanyName = "Company name",
                    Amount = (rnd.Next(100000) / 100m),
                    InvoiceStatus = (InvoiceStatus)(rnd.Next(3))
                });
            }

            return entities;
        }
    }
}

