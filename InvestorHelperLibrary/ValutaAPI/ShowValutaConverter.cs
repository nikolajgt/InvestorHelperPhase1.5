using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary.ValutaAPI
{
    public class ShowValutaConverter
    {
        private static string uservaluta;
        public static string userValuta
        {
            get { return uservaluta; }
            set { uservaluta = value; }

        }

        private static string uservaluta1;
        public static string userValuta1
        {
            get { return uservaluta1; }
            set { uservaluta1 = value; }

        }

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

        public void testRun()
        {
            writeAt(5, 5, "Valuta omregner", 0, 2);
            Console.WriteLine();
            Console.WriteLine("Hvad vil du omregne fra?");
            userValuta = Console.ReadLine().ToUpper();


            Console.WriteLine("Indtast beløb");
            var userMoney = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hvad vil du omregne til?");
            userValuta1 = Console.ReadLine().ToUpper();


            CurrencyConverter p = new CurrencyConverter();
            var show = p.RunEverything(userValuta, userValuta1, userMoney);
            Console.WriteLine(show.ToString());
        }
    }
}
