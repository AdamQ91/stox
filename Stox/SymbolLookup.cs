using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Stox
{
    public class SymbolLookup
    {
        public string currentPrice(string symbol)
        {
            /* This will pass in what the user inputs into the app
             * and properly format the API URL, which will return JSON
             */

            RootObject ro = null;
            string url = "http://dev.markitondemand.com/MODApis/Api/v2/Quote/json?symbol=" + symbol;

            try
            {
                HttpClient hc = new HttpClient();
                var stockUrl = hc.GetAsync(url);
                string jsonData = stockUrl.Result.Content.ReadAsStringAsync().Result;
                ro = JsonConvert.DeserializeObject<RootObject>(jsonData);                      
            }
            catch (Exception e){ return e.ToString(); }

            return ro.LastPrice.ToString();
        }
        public string marketCap (string symbol)
        {
            /* This will pass in what the user inputs into the app
            * and properly format the API URL, which will return JSON
            */

            RootObject ro = null;
            string url = "http://dev.markitondemand.com/MODApis/Api/v2/Quote/json?symbol=" + symbol;

            try
            {
                HttpClient hc = new HttpClient();
                var stockUrl = hc.GetAsync(url);
                string jsonData = stockUrl.Result.Content.ReadAsStringAsync().Result;
                ro = JsonConvert.DeserializeObject<RootObject>(jsonData);
            }
            catch (Exception e) { return e.ToString(); }

            return ro.MarketCap.ToString();
        }
        public class RootObject
        {
            public string Status { get; set; }
            public string Name { get; set; }
            public string Symbol { get; set; }
            public double LastPrice { get; set; }
            public double Change { get; set; }
            public double ChangePercent { get; set; }
            public string Timestamp { get; set; }
            public int MSDate { get; set; }
            public long MarketCap { get; set; }
            public int Volume { get; set; }
            public double ChangeYTD { get; set; }
            public double ChangePercentYTD { get; set; }
            public double High { get; set; }
            public double Low { get; set; }
            public double Open { get; set; }
        }
    }
}

