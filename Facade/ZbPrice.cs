using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Spider.Invest.Sys.ManualTrade.Calculator.Facade
{
    public class ZbPrice : BasePrice
    {
      

        protected override void OnInputChanged()
        {
            PriceNormalized = this.GetNormalizedPrice();
            double tickSize = 1.0d/32.0d;
            double stopSize = tickSize*StopLossSize;
            double targetSize = tickSize*ProfitTargetSize;

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
            return string.Format("{0}'{1}", PriceMainPart, PriceDecimalPart.ToString("00"));
        }

        public static ZbPrice LoadFromConfig()
        {
            string saved = Properties.Settings.Default.zbPrice;
            ZbPrice value = new ZbPrice();

            if (!string.IsNullOrWhiteSpace(saved))
            {
                try
                {
                    value = JsonConvert.DeserializeObject<ZbPrice>(saved);
                }
                catch
                {

                }
            }

            return value;
            ;
        }

        public static void SaveToConfig(ZbPrice price)
        {
            string saved = JsonConvert.SerializeObject(price);
            Properties.Settings.Default.zbPrice = saved;
            Properties.Settings.Default.Save();
        }
    }
}