using System;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class InvoiceDateTextColorConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch ((int) value)
            {
            case 0: return Color.Black;
            case 1: return Color.Black;
            case 2: return Color.White;
            default: return Color.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
