using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary
{
    public class PriceModel
    {
        public regularMarketOpen regularMarketOpen { get; set; }
        public regularMarketPreviousClose regularMarketPreviousClose { get; set; }
      //  public longName longName { get; set; }
        
    }

    public class regularMarketOpen
    {
        public decimal raw { get; set; }
    }

    public class regularMarketPreviousClose
    {
        public decimal raw { get; set; }
    }

    public class longName
    {
        public string name { get; set; }
    }

}
