using System;
using ControlTester.Models;
using Sage.SageOne.SageOneMobile.Controls.Style;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;

namespace ControlTester.ViewModels
{
    public class ExpenseViewModel : SimpleViewModel, IEntityLightViewModel
    {
        private readonly Expense _entity;

        public ExpenseViewModel(Expense entity)
        {  
            PrimaryKey = "1";
            _entity = entity; 

        }

        public string PrimaryKey { get; private set; }

        public string Title => _entity.ContactName;
        public string Subtitle => _entity.CompanyName;
        public string Amount => "$" + _entity.Amount.ToString();
        public string Info => String.Empty;
        public DisplayEnums InfoStatus => DisplayEnums.Info;
        public DateTime MonthAndDay => new DateTime(2015, 9, 24);
    }
}
