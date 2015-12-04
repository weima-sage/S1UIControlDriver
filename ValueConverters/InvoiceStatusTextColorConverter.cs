using System;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class InvoiceStatusTextColorConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch ((int) value)
            {
                case 0: return Color.FromHex("00ff7f");
                case 1: return Color.Gray;
                case 2: return Color.Red;
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

