using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InvestorHelperLibrary
{
    public class PriceProcessor
    {
        public static async Task<StockPriceResultModel> LoadOpeningPrice(string tickerSymbol)
        {
            var client = new HttpClient();
            ApiHelper helper = new ApiHelper();

            HttpRequestMessage url = ApiHelper.InitializeClient(tickerSymbol);

            using (var response = await client.SendAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    StockPriceResultModel result = await response.Content.ReadAsAsync<StockPriceResultModel>();
                    //Console.WriteLine("Beta: {0}   ShortRatio: {1}", result.defaultKeyStatistics.beta.raw.ToString(), result.defaultKeyStatistics.shortRatio.raw.ToString());
                    //Console.WriteLine("Open price: {0}  Previous close: {1}", result.price.regularMarketOpen.raw.ToString(), result.price.regularMarketPreviousClose.raw.ToString());
                    //Console.WriteLine("Data today: {0}", result.financialData.currentPrice.raw.ToString());
                    return result;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }

    }
}
