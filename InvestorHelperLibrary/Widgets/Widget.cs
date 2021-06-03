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


        public void ShowWidgetsFinance(int x)
        {
            writeAt(62, x, 2);
            Console.WriteLine("Current Price: {0} $ ");

            writeAt(62, x + 1, 2);
            Console.WriteLine("Previous close: {0} $");

            writeAt(62, x + 2, 2);
            Console.WriteLine("Shorted: {0} $");

            writeAt(62, x + 4, 2);
            Console.WriteLine("Shorted: {0} ");

            writeAt(62, x + 5, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, x + 6, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, x + 8, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, x + 9, 2);
            Console.WriteLine("Shorted: {0} kr");

            writeAt(62, x + 10, 2);
            Console.WriteLine("Shorted: {0} kr");
        }
    }
}
