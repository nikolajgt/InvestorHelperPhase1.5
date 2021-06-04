using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InvestorHelperLibrary
{
    public class StockInformation
    {

        public static void writeAtText(int x, int y, int foregroundcolor) // skriv tekst i farver til position
        {
            ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkYellow };
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colors[foregroundcolor];
        }
        public static void writeAtBox(int x, int y, string text, int foregroundcolor, int backgroundcolor) // skriv tekst i farver til position
        {
            ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkYellow };
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colors[foregroundcolor];
            Console.BackgroundColor = colors[backgroundcolor];
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;    //farver tilbage til default
            Console.BackgroundColor = ConsoleColor.Black;
        }


        public async void StockInfoRun()
        {
            var i = await PriceProcessor.LoadOpeningPrice("amc");

            writeAtBox(5, 5, "                              Valuta omregner                              ", 1, 2);
            writeAtBox(5, 20, "                                                                            ", 1, 2);

            writeAtText(62, 5, 2);
            Console.WriteLine("Current Price: {0} $ ", i.financialData.currentPrice.raw.ToString());

            writeAtText(62, 5 + 1, 2);
            Console.WriteLine("Previous close: {0} $", i.price.regularMarketPreviousClose.raw.ToString());

            writeAtText(62, 5 + 2, 2);
            Console.WriteLine("Shorted: {0} ", i.defaultKeyStatistics.shortRatio.raw.ToString());

            writeAtText(62, 5 + 4, 2);
            Console.WriteLine("Beta: {0} ", i.defaultKeyStatistics.beta.raw.ToString());

            writeAtText(62, 5 + 5, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAtText(62, 5 + 6, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAtText(62, 5 + 8, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAtText(62, 5 + 9, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAtText(62, 5 + 10, 2);
            Console.WriteLine("Shorted: {0} kr");
        }

    }
}
