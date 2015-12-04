using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ControlTester.Factories;

namespace ControlTester.ViewModels
{
    public class ExpenseListViewModel
    {
        private readonly IList<ExpenseViewModel> _entityList;

        public ExpenseListViewModel()
        {
            _entityList = new ObservableCollection<ExpenseViewModel>(
                ExpenseFactory.CreateExpenses(30).Select(e => new ExpenseViewModel(e))
            );
        }

        public IList<ExpenseViewModel> EntityList { get { return _entityList; } }

    }
}