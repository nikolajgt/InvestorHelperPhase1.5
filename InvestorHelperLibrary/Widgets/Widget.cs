using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary
{
    public class Widget
    {


        static void writeAt(int x, int y, int foregroundcolor) // skriv tekst i farver til position
        {
            ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkYellow };
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colors[foregroundcolor];

        }


        //Forskellige widgets som skal være under widget menuen. Brugerer skal kunne vælge hvilke der bliver vist.

        int opNed = 5;

        
        public async void RunAtStartUp()
        {
            string ticker = "VXRT";
            var sprm = await PriceProcessor.LoadOpeningPrice(ticker);
        }

        public void ShowWidgetsFinance()
        {
            writeAt(62, opNed, 2);
            Console.WriteLine("Current Price: {0} kr ", opNed);

            writeAt(62, opNed + 1, 2);
            Console.WriteLine("Previous close: {0} kr");

            writeAt(62, opNed + 2, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, opNed + 4, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, opNed + 5, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, opNed + 6, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, opNed + 8, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, opNed + 9, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, opNed + 10, 2);
            Console.WriteLine("Shorted: {0} kr");
        }
    }
}
