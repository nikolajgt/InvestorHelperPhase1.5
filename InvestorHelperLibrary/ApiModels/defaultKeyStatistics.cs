using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary.ApiModels
{
    public class defaultKeyStatistics
    {
        public shortRatio shortRatio { get; set; }  // get short ratio of a stock
        public beta beta { get; set; }          //volatillity of a stocks, if over 1.0 is volatille.
    }

    public class shortRatio
    {
        public decimal raw { get; set; }
    }

    public class beta
    {
        public decimal raw { get; set; }
    }
}
