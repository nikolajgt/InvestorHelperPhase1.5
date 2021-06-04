using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InvestorHelperLibrary
{
    public class Widget
    {

        public static void writeAt(int x, int y, int foregroundcolor) // skriv tekst i farver til position
        {
            ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkYellow };
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colors[foregroundcolor];
        }

       
    }
}
