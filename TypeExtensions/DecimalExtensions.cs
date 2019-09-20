public static class DecimalExtensions
{
    public static decimal Truncate(this decimal value, int precision)
    {
        var amount = value.ToString();

        if (amount.Contains(".") && amount.Length - amount.IndexOf(".") > precision)
        {
            return decimal.Parse(amount.Substring(0, amount.IndexOf(".") + precision + 1));
        }
        else
        {
            return value;
        }
    }

    public static decimal? Truncate(this decimal? value, int precision)
    {
        if (value == null) return null;

        var amount = value.ToString();

        if (amount.Contains(".") && amount.Length - amount.IndexOf(".") > precision)
        {
            return decimal.Parse(amount.Substring(0, amount.IndexOf(".") + precision + 1));
        }
        else
        {
            return value;
        }
    }
}
