using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ControlTester.Factories;

namespace ControlTester.ViewModels
{
    public class ProductListViewModel
    {
        private readonly IList<ProductViewModel> _entityList;

        public ProductListViewModel()
        {
            _entityList = new ObservableCollection<ProductViewModel>(
                ProductFactory.CreateProducts(30).Select(e => new ProductViewModel(e))
            );
        }

        public IList<ProductViewModel> EntityList { get { return _entityList; } }

    }
}