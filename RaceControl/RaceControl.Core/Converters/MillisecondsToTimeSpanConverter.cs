﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RaceControl.Core.Converters
{
    [ValueConversion(typeof(long), typeof(TimeSpan))]
    public class MillisecondsToTimeSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is long longValue)
            {
                return TimeSpan.FromMilliseconds(longValue);
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}