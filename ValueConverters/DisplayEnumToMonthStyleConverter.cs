using System;
using System.Globalization;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class DisplayEnumToMonthStyleConverter : DisplayEnumToMonthAndDayStyleConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value).MonthStyle;
        }
        public static readonly IValueConverter Instance = new DisplayEnumToMonthStyleConverter();
    }
}