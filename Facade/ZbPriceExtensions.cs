using System;
using System.Globalization;

namespace Spider.Invest.Sys.ManualTrade.Calculator.Facade
{
    public static class ZbPriceExtensions
    {
        public static double GetNormalizedPrice(this ZbPrice price)
        {
            return Convert.ToDouble(price.PriceMainPart) + (Convert.ToDouble(price.PriceDecimalPart)/32.0d);
        }

        public static ZbPrice GetZbPrice(this double price)
        {
            // now do the split - the apres decimal precision defined by 

            // the format function which defaults to 2 places i.e. "0.00"
            string splitValue = price.ToString(string.Format("0.{0}",
                new String('0', 10)), CultureInfo.InvariantCulture);
            string[] splitParts = splitValue.Split('.');

            var fractionPart = double.Parse("0." + splitParts[1]);
            int degreePart = Convert.ToInt32(fractionPart*32);
            // now factor out derived splits as ints into struct
            var value = new ZbPrice
            {
                PriceMainPart = int.Parse(splitParts[0]),
                PriceDecimalPart = degreePart
            };

            return value;
        }
    }
}