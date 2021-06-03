using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace InvestorHelperLibrary
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static HttpRequestMessage InitializeClient(string tickerSymbol)
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-statistics?symbol={ tickerSymbol }&region=US"),
                Headers =
                {
                    { "x-rapidapi-key", "8ae3cc9430msh9eb3f89bce24226p121cbcjsn4be8e2b40433" },
                    { "x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
            };
            return request;
        }
    }
}
