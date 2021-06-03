using InvestorHelperLibrary.ApiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary
{
    public class StockPriceResultModel
    {
        public PriceModel price { get; set; }  //Data before
        public defaultKeyStatistics defaultKeyStatistics { get; set; }
        public financialData financialData { get; set; }  //Data now
    }
}
