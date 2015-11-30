using System;
using Newtonsoft.Json;

namespace Spider.Invest.Sys.ManualTrade.Calculator.Facade
{
    public class EsPrice : BasePrice
    {
        protected override void OnInputChanged()
        {
            PriceNormalized = Convert.ToDouble(PriceMainPart) + (Convert.ToDouble(PriceDecimalPart)/100.0d);
            double tickSize = 1.0d;
            double stopSize = tickSize * StopLossSize;
            double targetSize = tickSize * ProfitTargetSize;

            if (IsLong)
            {
                StopPrice = PriceNormalized - stopSize;
                TargetPrice = PriceNormalized + targetSize;
            }
            else
            {
                StopPrice = PriceNormalized + stopSize;
                TargetPrice = PriceNormalized - targetSize;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", PriceMainPart, PriceDecimalPart.ToString("00"));
        }

        public static EsPrice LoadFromConfig()
        {
            string saved = Properties.Settings.Default.esPrice;
            EsPrice value = new EsPrice();

            if (!string.IsNullOrWhiteSpace(saved))
            {
                try
                {
                    value = JsonConvert.DeserializeObject<EsPrice>(saved);
                }
                catch
                {

                }
            }

            return value;
            ;
        }

        public static void SaveToConfig(EsPrice price)
        {
            string saved = JsonConvert.SerializeObject(price);
            Properties.Settings.Default.esPrice = saved;
            Properties.Settings.Default.Save();
        }
    }
}