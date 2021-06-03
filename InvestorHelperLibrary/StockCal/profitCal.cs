using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary.StockCal
{
    class profitCal
    {
        // TODO:
        // Lav procent/fixed tal på buy/sell commission
        // Gør mere dum sikker ( Programmet ikke crasher hvis man indtaster bogstav ) 

        private int numberShares;
        private int purchasePrice;
        private int sellPrice;
        private int buyCommission;
        private int sellCommission;

        private int profit;

        public void startCal()
        {
            Console.WriteLine("Hvor mange shares har du købt?");
            numberShares = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er købsprisen?");
            purchasePrice = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er salgsprisen?");
            sellPrice = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er købs provision?");
            buyCommission = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er salgs provision?");
            sellCommission = Int32.Parse(Console.ReadLine());

            profit = stockFormula(numberShares, purchasePrice, sellPrice, buyCommission, sellCommission);
            Console.WriteLine(profit.ToString());
            throksodk db = new throksodk();
            db.MariaDBMoneyWrite();
        }

        private int stockFormula(int numberS, int purchaseP, int sellP, int buyC, int sellC)
        {
            try
            {
                int finalAnswer = ((sellP * numberS) - sellC) - ((purchaseP * numberS) + buyC);

                return finalAnswer;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            return 0;
        }

    }

    class TaxCal
    {
        public double toTax;

        private int taxProcentage = 18;
        public void startCal()
        {
            Console.WriteLine("Indtast dit profit");
            var userAnswer = Int32.Parse(Console.ReadLine());

            var profitAnswer = taxCalculator(userAnswer);
            Console.WriteLine("Du skal betale {0} kr i skat", profitAnswer);
        }

        private double taxCalculator(int profit)
        {

            toTax = profit * taxProcentage / 100;
            // GetSetData gsd = new GetSetData();
            // gsd.widget1 = toTax;

            return toTax;
        }
    }
}