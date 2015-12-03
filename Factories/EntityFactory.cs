using System;
using ControlTester.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControlTester
{
    public static class EntityFactory
    {
        public static ObservableCollection<Entity> CreateEntites(int numEntities)
        {
            var entities = new ObservableCollection<Entity>();
            Random rnd = new Random(0);
            for(int i = 1; i < numEntities + 1; ++i)
            {
                entities.Add(new Entity { 
                    Title = "Contact name", 
                    Subtitle = "Company name",
                    Amount = (i * 1001) / 100m,
                    InfoStatus = (InfoStatus)(rnd.Next(3))
                });
            }

            return entities;
        }
    }
}

