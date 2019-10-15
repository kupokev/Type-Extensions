using static System.Math;

namespace TypeExtensions
{
    public static class DecimalExtensions
    {
        public static decimal Trunc(this decimal value, int precision)
        {
            var amount = (decimal)Pow(10, precision);

            return Truncate(value * amount) / amount;
        }

        public static decimal? Trunc(this decimal? value, int precision)
        {
            if (value == null) return null;

            var amount = (decimal)Pow(10, precision);

            return Truncate((decimal)value * amount) / amount;
        }
    }
}