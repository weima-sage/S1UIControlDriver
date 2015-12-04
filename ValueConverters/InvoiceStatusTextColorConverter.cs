﻿using System;
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
                case 0: return Color.FromHex("41c681");
                case 1: return Color.FromHex("858680");
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

