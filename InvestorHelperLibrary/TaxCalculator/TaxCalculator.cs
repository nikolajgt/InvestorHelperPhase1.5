using System;
using System.Collections.Generic;
using System.Text;


namespace InvestorHelperLibrary.TaxCalculator
{
    public class TaxCalculator
    {
   
        private double tax;

        private int taxProcentage = 18;
        public void TaxCalculatorRun()
        {
            StockInformation.writeAtBox(5, 5, "                              Tax Calculator                              ", 1, 2);
            StockInformation.writeAtBox(5, 20, "                                                                         ", 1, 2);

            StockInformation.writeAtText(25, 7, 2);
            Console.Write("Indtast dit profit: ");
            var userAnswer = Int32.Parse(Console.ReadLine());

            var profitAnswer = Calculator(userAnswer);
            StockInformation.writeAtText(25, 9, 2);
            Console.Write("Du skal betale {0} kr i skat", profitAnswer);
        }

        private double Calculator(int profit)
        {

            tax = profit * taxProcentage / 100;
            return tax;
        }
    }
}
