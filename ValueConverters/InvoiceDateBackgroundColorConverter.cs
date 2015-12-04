using System;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class InvoiceDateBackgroundColorConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch ((int) value)
            {
            case 0: return Color.White;
            case 1: return Color.FromHex("cacbc8");
            case 2: return Color.FromHex("ca2a60");
            default: return Color.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

