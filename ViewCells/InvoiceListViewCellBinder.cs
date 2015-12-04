using System;
using Sage.SageOne.SageOneMobile.Controls.ViewCells;
using Xamarin.Forms;
using ControlTester.ValueConverters;

namespace ControlTester.ViewCells
{
    public class InvoiceListViewCellBinder : BaseListViewCellBinder
    {
        public override Binding InfoTextColorBinding()
        {
            return new Binding(
                "InfoStatus", 
                BindingMode.OneWay, 
                new InvoiceStatusTextColorConverter()
            );
        }        
    }
}

