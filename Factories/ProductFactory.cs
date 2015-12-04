using System;
using ControlTester.Models;
using System.Collections.Generic;

namespace ControlTester.Factories
{
    public static class ProductFactory
    {
        public static IList<Product> CreateProducts(int numProducts)
        {
            var entities = new List<Product>();
            Random rnd = new Random();
            for(int i = 1; i < numProducts + 1; ++i)
            {
                entities.Add(new Product { 
                    Description = "Some description", 
                    TypeOfSale = "Type of sale",
                    Amount = (rnd.Next(100000) / 100m),
                });
            }

            return entities;
        }
    }
}

