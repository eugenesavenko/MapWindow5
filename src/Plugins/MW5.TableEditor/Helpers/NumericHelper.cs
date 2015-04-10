﻿using System.Globalization;

namespace MW5.Plugins.TableEditor.Helpers
{
    /// <summary>
    ///  Parsing strings operations with numbers
    /// </summary>
    public static class NumericHelper
    {
        /// <summary>Check if a value is nummeric</summary>
        /// <param name = "value">The value to check.</param>
        /// <param name = "style">The NumberStyle</param>
        /// <returns>Status indicating if value is nummeric</returns> 
        public static bool IsNumeric(string value, NumberStyles style)
        {
            double result;

            return double.TryParse(value, style, CultureInfo.CurrentCulture, out result);
        }
    }
}