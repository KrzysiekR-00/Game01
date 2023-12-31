﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Project2.Presentation.Views.Converters
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class InverseBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
