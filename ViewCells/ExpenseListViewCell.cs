using System;
using Sage.SageOne.SageOneMobile.Controls.ViewCells;
using Sage.SageOne.SageOneMobile.Controls.Views;
using Xamarin.Forms;
using ControlTester.ValueConverters;

namespace ControlTester.ViewCells
{
    public class ExpenseListViewCell 
        : EntityListViewCell<ExpenseListViewCellBinder>
    {
        protected override View PrependView()
        {
            return new MonthAndDayView();
        }
    }

}
