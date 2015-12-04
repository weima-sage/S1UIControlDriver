using System;
using ControlTester.Models;
using System.Collections.ObjectModel;

namespace ControlTester.Factories
{
    public static class ProductFactory
    {
        public static ObservableCollection<Product> CreateProducts(int numProducts)
        {
            var entities = new ObservableCollection<Product>();
            Random rnd = new Random(0);
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

