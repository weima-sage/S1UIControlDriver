using System;
using ControlTester.Models;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;

namespace ControlTester.ViewModels
{
    public class ExpenseViewModel : SimpleViewModel, IEntityViewModel
    {
        private readonly Expense _entity;

        public ExpenseViewModel(Expense entity) {  _entity = entity; }

        public string Title => _entity.ContactName;
        public string Subtitle => _entity.CompanyName;
        public string Amount => "$" + _entity.Amount.ToString();
        public string Info => String.Empty;
        public int InfoStatus => 0;
        public DateTime MonthAndDay => new DateTime(2015, 9, 24);
    }
}
