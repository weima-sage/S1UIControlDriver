using System;
using Sage.SageOne.SageOneMobile.Controls.Style;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class InvoiceStatusTextColorConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch ((DisplayEnums) value)
            {
                case DisplayEnums.AwfulNews:
                    return Color.FromHex("#CA2A60");
                case DisplayEnums.BadNews:
                    return Color.FromHex("#A8A9A4");
                case DisplayEnums.Info:
                case DisplayEnums.GoodNews:
                case DisplayEnums.GreatNews:
                case DisplayEnums.Party:
                    return Color.FromHex("#38C72A");
                default:
                    return Color.FromHex("#38C72A");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

