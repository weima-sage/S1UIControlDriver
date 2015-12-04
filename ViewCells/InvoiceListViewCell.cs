using System;
using Sage.SageOne.SageOneMobile.Controls.ViewCells;
using Sage.SageOne.SageOneMobile.Controls.Views;
using Xamarin.Forms;
using ControlTester.ValueConverters;

namespace ControlTester.ViewCells
{
    public class InvoiceListViewCell 
        : EntityListViewCell<InvoiceListViewCellBinder>
    {
        protected override View PrependView()
        {
            var converter = new InvoiceDateColorConverter();
            var binding = new Binding("InfoStatus", BindingMode.OneWay, converter);
            return new MonthAndDayView(binding);
        }
    }

}

