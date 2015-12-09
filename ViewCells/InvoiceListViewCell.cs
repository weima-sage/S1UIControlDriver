using System;
using Sage.SageOne.SageOneMobile.Controls.ViewCells;
using Sage.SageOne.SageOneMobile.Controls.Views;
using Xamarin.Forms;
using ControlTester.ValueConverters;

namespace ControlTester.ViewCells
{
    public class InvoiceListViewCell : EntityListViewCell
    {
        public InvoiceListViewCell()
            :base(new InvoiceListViewCellBinder()){}

        protected override View PrependView()
        {
            var converterTextColor = 
                new InvoiceDateTextColorConverter();
            var bindingMonthTextColor = 
                new Binding("InfoStatus", BindingMode.OneWay, converterTextColor);
            var bindingDayTextColor = 
                new Binding("InfoStatus", BindingMode.OneWay, converterTextColor);

            var converterBackgroundColor = 
                new InvoiceDateBackgroundColorConverter();
            var bindingBackgroundColor = 
                new Binding("InfoStatus", BindingMode.OneWay, converterBackgroundColor);
            
            return new MonthAndDayView(
                bindingMonthTextColor, 
                bindingDayTextColor,
                bindingBackgroundColor);
        }
    }

}

