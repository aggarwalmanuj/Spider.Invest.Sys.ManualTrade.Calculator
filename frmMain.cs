using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spider.Invest.Sys.ManualTrade.Calculator.Facade;

namespace Spider.Invest.Sys.ManualTrade.Calculator
{
    public partial class frmMain : Form
    {
        private ZbPrice m_ZbPrice = new ZbPrice();
        private EsPrice m_EsPrice = new EsPrice();

        private bool isInternalChange = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ZbInputChanged(object sender, EventArgs e)
        {
            if (isInternalChange)
                return;

            UpdateZbUi();
        }

        private void UpdateZbUi()
        {
            m_ZbPrice.PriceMainPart = Convert.ToInt32(numZbPriceMain.Value);
            m_ZbPrice.PriceDecimalPart = Convert.ToInt32(numZbPriceDegrees.Value);
            m_ZbPrice.IsLong = radZbLong.Checked;
            m_ZbPrice.StopLossSize = Convert.ToInt32(numZbStopLossSize.Value);
            m_ZbPrice.ProfitTargetSize = Convert.ToInt32(numZbProfitTargetSize.Value);

            lblZbPriceNormalized.Text = m_ZbPrice.PriceNormalized.ToString();
            txtZbStopDecimals.Text = m_ZbPrice.StopPrice.ToString();
            txtZbStopDegrees.Text = m_ZbPrice.StopPrice.GetZbPrice().ToString();

            txtZbTargetDecimals.Text = m_ZbPrice.TargetPrice.ToString();
            txtZbTargetDegrees.Text = m_ZbPrice.TargetPrice.GetZbPrice().ToString();
        }

        private void LoadSavedConfig(ZbPrice price)
        {
            radZbLong.Checked = price.IsLong;
            radZbShort.Checked = !price.IsLong;
            numZbStopLossSize.Value = Convert.ToDecimal(price.StopLossSize);
            numZbProfitTargetSize.Value = Convert.ToDecimal(price.ProfitTargetSize);
            numZbPriceMain.Value = Convert.ToDecimal(price.PriceMainPart);
            numZbPriceDegrees.Value = Convert.ToDecimal(price.PriceDecimalPart);
        }


        private void LoadSavedConfig(EsPrice price)
        {
            radEsLong.Checked = price.IsLong;
            radEsShort.Checked = !price.IsLong;
            numEsStopLossSize.Value = Convert.ToDecimal(price.StopLossSize);
            numEsProfitTargetSize.Value = Convert.ToDecimal(price.ProfitTargetSize);
            numEsPriceMain.Value = Convert.ToDecimal(price.PriceMainPart);
            numEsPriceDecimals.Value = Convert.ToDecimal(price.PriceDecimalPart);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                isInternalChange = true;
                m_ZbPrice = ZbPrice.LoadFromConfig();
                m_EsPrice = EsPrice.LoadFromConfig();

                LoadSavedConfig(m_ZbPrice);
                LoadSavedConfig(m_EsPrice);
            }
            finally
            {
                isInternalChange = false;
            }

            UpdateZbUi();
            UpdateEsUi();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            EsPrice.SaveToConfig(m_EsPrice);
            ZbPrice.SaveToConfig(m_ZbPrice);
        }

        private void EsInputChanged(object sender, EventArgs e)
        {

            if (isInternalChange)
                return;

            UpdateEsUi();
        }

        private void UpdateEsUi()
        {
            m_EsPrice.PriceMainPart = Convert.ToInt32(numEsPriceMain.Value);
            m_EsPrice.PriceDecimalPart = Convert.ToInt32(numEsPriceDecimals.Value);
            m_EsPrice.IsLong = radEsLong.Checked;
            m_EsPrice.StopLossSize = Convert.ToInt32(numEsStopLossSize.Value);
            m_EsPrice.ProfitTargetSize = Convert.ToInt32(numEsProfitTargetSize.Value);

            lblEsPriceNormalized.Text = m_EsPrice.PriceNormalized.ToString();
            txtEsStopLossPrice.Text = m_EsPrice.StopPrice.ToString();

            txtEsTargetPrice.Text = m_EsPrice.TargetPrice.ToString();
        }
    }
}
