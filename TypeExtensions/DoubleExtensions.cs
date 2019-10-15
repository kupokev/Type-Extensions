using static System.Math;

namespace TypeExtensions
{
    public static class DoubleExtensions
    {
        public static double Trunc(this double value, int precision)
        {
            var amount = Pow(10, precision);

            return Truncate(value * amount) / amount;
        }

        public static double? Trunc(this double? value, int precision)
        {
            if (value == null) return null;

            var amount = Pow(10, precision);

            return Truncate((double)value * amount) / amount;
        }
    }
}