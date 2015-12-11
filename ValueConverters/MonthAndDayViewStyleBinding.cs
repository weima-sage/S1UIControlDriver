using System;
using System.Collections.Generic;
using System.Text;
using Sage.SageOne.SageOneMobile.Controls.Style;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;
using Xamarin.Forms;

namespace ControlTester.ValueConverters
{
    public class MonthAndDayViewStyleBinding:IMonthAndDayViewStyleBinding
    {

        public static MonthAndDayViewStyleBinding CreateInstance =>
            new MonthAndDayViewStyleBinding(DisplayEnumToDayStyleConverter.Instance, DisplayEnumToMonthStyleConverter.Instance, DisplayEnumToContentStyleConverter.Instance);

        public Binding DayBinding { get; }
        public Binding MonthBinding { get; }
        public Binding ContentBinding { get; }

        private MonthAndDayViewStyleBinding(IValueConverter dayStyleConverter, IValueConverter monthStyleConverter,
            IValueConverter contentStyleConverter)
        {
            DayBinding = GetBinding(dayStyleConverter);
            MonthBinding = GetBinding(monthStyleConverter);
            ContentBinding = GetBinding(contentStyleConverter);
        }

        private Binding GetBinding(IValueConverter converter)
        {
            return new Binding(nameof(IEntityLightViewModel.InfoStatus), BindingMode.OneWay, converter);
        }
    }
}
