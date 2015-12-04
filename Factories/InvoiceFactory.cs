using System;
using ControlTester.Models;
using System.Collections.Generic;

namespace ControlTester.Factories
{
    public static class InvoiceFactory
    {
        public static IList<Invoice> CreateInvoices(int numInvoices)
        {
            var entities = new List<Invoice>();
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

