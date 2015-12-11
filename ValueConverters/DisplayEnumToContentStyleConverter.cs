using System;
using System.Globalization;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class DisplayEnumToContentStyleConverter : DisplayEnumToMonthAndDayStyleConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value).ContentStyle;
        }
        public static readonly IValueConverter Instance = new DisplayEnumToContentStyleConverter();
    }
}