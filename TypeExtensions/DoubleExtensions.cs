namespace TypeExtensions
{
    public static class DoubleExtensions
    {
        public static double Truncate(this double value, int precision)
        {
            var amount = value.ToString();

            if (amount.Contains(".") && amount.Length - amount.IndexOf(".") > precision)
            {
                return double.Parse(amount.Substring(0, amount.IndexOf(".") + precision + 1));
            }
            else
            {
                return value;
            }
        }

        public static double? Truncate(this double? value, int precision)
        {
            if (value == null) return null;

            var amount = value.ToString();

            if (amount.Contains(".") && amount.Length - amount.IndexOf(".") > precision)
            {
                return double.Parse(amount.Substring(0, amount.IndexOf(".") + precision + 1));
            }
            else
            {
                return value;
            }
        }
    }
}