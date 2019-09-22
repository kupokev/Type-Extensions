using System;

namespace TypeExtensions
{
    public static class DoubleExtensions
    {
        public static double Truncate(this double value, int precision)
        {
            var amount = Math.Pow(10, precision);

            return Math.Truncate(value * amount) / amount;
        }

        public static double? Truncate(this double? value, int precision)
        {
            if (value == null) return null;

            var amount = Math.Pow(10, precision);

            return Math.Truncate((double)value * amount) / amount;
        }
    }
}