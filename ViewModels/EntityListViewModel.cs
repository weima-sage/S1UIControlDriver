using System;
using System.ComponentModel;
using ControlTester.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ControlTester.ViewModels
{
    public class EntityListViewModel
    {
        private readonly IList<EntityViewModel> _entityList;

        public EntityListViewModel()
        {
            _entityList = new ObservableCollection<EntityViewModel>(
                EntityFactory.CreateEntites(30).Select(e => new EntityViewModel(e))
            );
        }

        public IList<EntityViewModel> EntityList { get { return _entityList; } }
            
    }
}

