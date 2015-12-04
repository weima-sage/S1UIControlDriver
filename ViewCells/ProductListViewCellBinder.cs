using System;
using Sage.SageOne.SageOneMobile.Controls.ViewCells;
using Xamarin.Forms;
using ControlTester.ValueConverters;

namespace ControlTester.ViewCells
{
    public class ProductListViewCellBinder : BaseListViewCellBinder
    {
        public override Binding InfoTextColorBinding()
        {
            // Find better way to push color over without needing to bind. 
            // Color is static for product
            return new Binding(
                "Info", 
                BindingMode.OneWay, 
                new ProductStatusTextColorConverter()
            );
        }        
    }
}
