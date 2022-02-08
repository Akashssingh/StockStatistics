using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YahooFinanceApi;
using System.Threading.Tasks;

namespace Project3Group16
{
    class Data
    {
        public List<DataPoint> dataPoints = new List<DataPoint>();
        public int getData(string ticker, DateTime start, DateTime end)
        {
            try
            {
                var data = Yahoo.GetHistoricalAsync(ticker, start, end).Result;
                var security = Yahoo.Symbols(ticker).Fields(Field.LongName).QueryAsync().Result;
                var symbol = security[ticker];
                var companyName = symbol[Field.LongName];

                decimal hi = 0;
                decimal lo = decimal.MaxValue;
                decimal open = Math.Round(data.ElementAt(0).Open, 2);
                decimal close = Math.Round(data.ElementAt(data.Count - 1).Close, 2);

                for (int i = 0; i < data.Count; i++)
                {
                    //Console.WriteLine(companyName + "closing: " + data.ElementAt(i).DateTime.Month + "/" + data.ElementAt(i).DateTime.Day + "/" + data.ElementAt(i).DateTime.Year + ": $" + Math.Round(data.ElementAt(i).Close, 2));
                    if (hi < Math.Round(data.ElementAt(i).High, 2))
                        hi = Math.Round(data.ElementAt(i).High, 2);
                    if (lo > Math.Round(data.ElementAt(i).Low, 2))
                        lo = Math.Round(data.ElementAt(i).Low, 2);
                }
                DataPoint dt = new DataPoint(start, lo, hi, open, close);

                dataPoints.Add(dt);
            }
            catch
            {
                Console.WriteLine("error");
            }
            return 1;
        }
    }

    //create class to pass on data 
    public class DataPoint
    {
        public DateTime startDate { get; set; }
        public decimal Low { get; set; }
        public decimal High { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public DataPoint(DateTime start, decimal low, decimal high, decimal open, decimal close)
        {
            this.startDate = start;
            this.Low = low;
            this.High = high;
            this.Open = open;
            this.Close = close;
        }
    }
}
