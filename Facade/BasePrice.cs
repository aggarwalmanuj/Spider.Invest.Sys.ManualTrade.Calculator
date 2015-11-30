namespace Spider.Invest.Sys.ManualTrade.Calculator.Facade
{
    public abstract class BasePrice
    {
        private double _profitTargetSize;
        private double _stopLossSize;
        private bool _isLong;

        protected abstract void OnInputChanged();
        private int _priceMainPart;
        private int _priceDecimalPart;

        public int PriceMainPart
        {
            get { return _priceMainPart; }
            set
            {
                _priceMainPart = value;
                OnInputChanged();
            }
        }

        public int PriceDecimalPart
        {
            get { return _priceDecimalPart; }
            set
            {
                _priceDecimalPart = value;
                OnInputChanged();
            }
        }

        public bool IsLong
        {
            get { return _isLong; }
            set
            {
                _isLong = value;
                OnInputChanged();
            }
        }

        public double ProfitTargetSize
        {
            get { return _profitTargetSize; }
            set
            {
                _profitTargetSize = value;
                OnInputChanged();
            }
        }

        public double StopLossSize
        {
            get { return _stopLossSize; }
            set
            {
                _stopLossSize = value;
                OnInputChanged();
            }
        }

        public double PriceNormalized { get; protected set; }
        public double StopPrice { get; protected set; }
        public double TargetPrice { get; protected set; }
    }
}