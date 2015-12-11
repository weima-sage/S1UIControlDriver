using System;
using System.Globalization;
using Sage.SageOne.SageOneMobile.Controls.Style;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public abstract class DisplayEnumToMonthAndDayStyleConverter:IValueConverter
    {
        protected MonthAndDayViewStyle Convert(object value)
        {
            DisplayEnums vdisplay = (DisplayEnums)value;
            switch (vdisplay)
            {
                case DisplayEnums.AwfulNews:
                    return MonthAndDayViewStyle.UrgentStyle;
                case DisplayEnums.BadNews:
                    return MonthAndDayViewStyle.WarnStyle;
                case DisplayEnums.Info:
                case DisplayEnums.GoodNews:
                case DisplayEnums.GreatNews:
                case DisplayEnums.Party:
                default:
                    return MonthAndDayViewStyle.NormalStyle;
            }
        }

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
