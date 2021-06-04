using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary.ValutaAPI
{
    public class ShowValutaConverter
    {

        //view for hele valuta omregner

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

        public void StartValutaCalculator()
        {
            writeAt(5, 5, "                              Valuta omregner                              ", 1, 2);
            writeAt(5, 20, "                                                                            ", 1, 2);
            writeAt(25, 7, "Hvad vil du omregne fra?\b", 2, 0);
            writeAt(55, 7, "", 1, 2);
            var userValuta = Console.ReadLine().ToUpper();

            writeAt(25, 9, "Indtast dit beløb\b", 2, 0);
            writeAt(55, 9, "", 1, 2);
            var userMoney = Int32.Parse(Console.ReadLine());

            writeAt(25, 11, "Hvad vil du omregne til?\b", 2, 0);
            writeAt(55, 11, "", 1, 2);
            var userValuta1 = Console.ReadLine().ToUpper();

            CurrencyConverter p = new CurrencyConverter();
            var show = p.RunMethods(userValuta, userValuta1, userMoney);
            writeAt(25, 15, "Det bliver: \b", 2, 0);
            writeAt(55, 15, "", 1, 2);
            Console.WriteLine("{0} {1}", show.Result, userValuta1);

        }
    }
}
