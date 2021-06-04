using InvestorHelperLibrary.ValutaAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary.StockCal
{
    public class ShowStockCalculator
    {
        static void writeAt(int x, int y, string text, int foregroundcolor, int backgroundcolor)
        {
            ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkYellow };
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colors[foregroundcolor];
            Console.BackgroundColor = colors[backgroundcolor];
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void StartStockCalculator()
        {
            writeAt(5, 5, "                              $Stock Calculator$                              ", 1, 2);
            writeAt(5, 20, "                                                                               ", 1, 2);

            writeAt(25, 7, "Number of shares purchased?\b", 2, 0);
            writeAt(55, 7, "", 1, 2);
            var numberShares = Int32.Parse(Console.ReadLine());

            writeAt(25, 9, "Price when purchased?\b", 2, 0);
            writeAt(55, 9, "", 1, 2);
            var purchasePrice = Int32.Parse(Console.ReadLine());

            writeAt(25, 11, "Price when sold\b", 2, 0);
            writeAt(55, 11, "", 1, 2);
            var sellPrice = Int32.Parse(Console.ReadLine());

            writeAt(25, 13, "Commission when purchased?\b", 2, 0);
            writeAt(55, 13, "", 1, 2);
            var buyCommission = Int32.Parse(Console.ReadLine());

            writeAt(25, 15, "Commission when sold?\b", 2, 0);
            writeAt(55, 15, "", 1, 2);
            var sellCommission = Int32.Parse(Console.ReadLine());

            StockCalculator sc = new StockCalculator();

            var profit = sc.stockFormula(numberShares, purchasePrice, sellPrice, buyCommission, sellCommission);
            writeAt(25, 17, "Det bliver: \b", 2, 0);
            writeAt(55, 17, "", 1, 2);
            Console.WriteLine("{0} USD",profit.ToString());

            CurrencyConverter cc = new CurrencyConverter();
            var i = cc.RunMethods("USD", "DKK", profit);
            writeAt(60, 17, "", 1, 2);

            var nottask = Convert.ToDouble(i.Result);
            double x = Math.Truncate(nottask * 100) / 100;
            Console.WriteLine("  ( {0} DKK )", x);



        }

    }
}
