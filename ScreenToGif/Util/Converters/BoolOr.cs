﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace ScreenToGif.Util.Converters
{
    /// <summary>
    /// Multi-value converter.
    /// Check if any bools are true.
    /// Pass any parameter to invert the logic.
    /// </summary>
    public class BoolOr : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var res = values.Cast<bool>().Any(x => x);

            //If there's any parameter, invert the logic.
            return parameter != null ? !res : res;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}