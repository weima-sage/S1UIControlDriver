using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ControlTester.Factories;

namespace ControlTester.ViewModels
{
    public class InvoiceListViewModel
    {
        private readonly IList<InvoiceViewModel> _entityList;

        public InvoiceListViewModel()
        {
            _entityList = new ObservableCollection<InvoiceViewModel>(
                InvoiceFactory.CreateInvoices(30).Select(e => new InvoiceViewModel(e))
            );
        }

        public IList<InvoiceViewModel> EntityList { get { return _entityList; } }
            
    }
}

