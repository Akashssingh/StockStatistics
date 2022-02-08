using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project3Group16
{
    public partial class dataForm : Form
    {
        string ticker = "";
        int period;
        DateTime start;
        DateTime end;

        public dataForm(int t, int p, DateTime s, DateTime e)
        {
            InitializeComponent();
            start = s;
            end = e;

            //set ticker name vased on t value
            switch(t)
            {
                case 0:
                    ticker = "AAPL";
                    break;
                case 1:
                    ticker = "AMZN";
                    break;
                case 2:
                    ticker = "FB";
                    break;
                case 3:
                    ticker = "GOOGL";
                    break;
                case 4:
                    ticker = "HPQ";
                    break;
                case 5:
                    ticker = "IBM";
                    break;
                case 6:
                    ticker = "INTC";
                    break;
                case 7:
                    ticker = "MSFT";
                    break;
                case 8:
                    ticker = "NFLX";
                    break;
                case 9:
                    ticker = "TSLA";
                    break;
                default:
                    break;
            }

            //initialize series
            Series price = new Series();
            chart1.Series.Add(price);

            //switch period to nums
            switch (p)
            {
                case 0:
                    period = 1;
                    price.Name = "Daily";
                    break;
                case 1:
                    period = 7;
                    price.Name = "Weekly";
                    break;
                case 2:
                    period = -1;
                    price.Name = "Monthly";
                    break;
                default:
                    break;
            }

            //make chart
            chart1.Series[price.Name].ChartType = SeriesChartType.Candlestick;
            chart1.Series[price.Name]["PriceUpColor"] = "Green";
            chart1.Series[price.Name]["PriceDownColor"] = "Red";

            //determines period for chart
            DateTime r1 = start;
            DateTime r2;
            if (period == -1)
            {
                r2 = r1.AddMonths(1);
            }
            else
            {
                r2 = r1.AddDays(period);
            }

            Data stock = new Data();
            while (DateTime.Compare(r1, end) < 0)
            {
                if (DateTime.Compare(r2, end) > 0)
                {
                    r2 = end;
                }
                
                var wait = stock.getData(ticker, r1, r2);

                if (period == -1)
                {
                    r1 = r1.AddMonths(1);
                    r2 = r2.AddMonths(1);
                }
                else
                {
                    r1 = r1.AddDays(period);
                    r2 = r2.AddDays(period);
                }
            }

            //make chart using values from Data class
            chart1.Series[price.Name].XValueMember = "startDate";
            chart1.Series[price.Name].YValueMembers = "High,Low,Open,Close";
            chart1.Series[price.Name].XValueType = ChartValueType.Date;
            chart1.DataManipulator.IsStartFromFirst = true;
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;

            chart1.DataSource = stock.dataPoints;
            chart1.DataBind();
            /*
            for (int i = 0; i < stock.dataPoints.Count; i++)
            {
                int count = chart1.Series[price.Name].Points.Count;
                Console.WriteLine(stock.dataPoints[i].High);
                chart1.Series[price.Name].Points.AddXY(stock.dataPoints[i].startDate, stock.dataPoints[i].High);
                chart1.Series[price.Name].Points[count].YValues[1] = Convert.ToDouble(stock.dataPoints[i].Low);
                chart1.Series[price.Name].Points[count].YValues[2] = Convert.ToDouble(stock.dataPoints[i].Open);
                chart1.Series[price.Name].Points[count].YValues[3] = Convert.ToDouble(stock.dataPoints[i].Close);

            }
            */

        }
    }
}
