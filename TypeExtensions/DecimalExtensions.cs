using System;

namespace TypeExtensions
{
    public static class DecimalExtensions
    {
        public static decimal Truncate(this decimal value, int precision)
        {
            var amount = (decimal)Math.Pow(10, precision);

            return Math.Truncate(value * amount) / amount;
        }

        public static decimal? Truncate(this decimal? value, int precision)
        {
            if (value == null) return null;

            var amount = (decimal)Math.Pow(10, precision);

            return Math.Truncate((decimal)value * amount) / amount;
        }
    }
}