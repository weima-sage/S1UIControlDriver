using System;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class InvoiceDateColorConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch ((int) value)
            {
            case 0: return Color.White;
            case 1: return Color.Gray;
            case 2: return Color.FromHex("cd5c5c");
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

