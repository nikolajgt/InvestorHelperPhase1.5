using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary.ApiModels
{
    public class financialData
    {
        public currentPrice currentPrice { get; set; }
    }

    public class currentPrice
    {
        public decimal raw { get; set; }
    }
}
