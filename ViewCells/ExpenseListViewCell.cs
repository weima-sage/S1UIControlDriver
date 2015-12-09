using System;
using Sage.SageOne.SageOneMobile.Controls.ViewCells;
using Sage.SageOne.SageOneMobile.Controls.Views;
using Xamarin.Forms;
using ControlTester.ValueConverters;

namespace ControlTester.ViewCells
{
    public class ExpenseListViewCell : EntityListViewCell
    {
        public ExpenseListViewCell()
            :base(new ExpenseListViewCellBinder()){}

        protected override View PrependView()
        {
            return new MonthAndDayView();
        }
    }

}
