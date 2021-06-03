using InvestorHelperLibrary.ValutaAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperStockPrice
{
    class Menu
    {
        private int BackgroundColor = 2;
        private int ForegroundColor = 0;

        static bool refresh = false;

        static int hovedMenuValg;  // med 0-15

        static string[] HovedMenuEmner = { "Valuta Calculator", "Stock Calculator", "Tax Calculator", "Nothing", "Nothing", "Stock details", "WSB tickers mentions", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Change console settings" };

        public void setConsoleSettings(int back, int fore)
        {
            BackgroundColor = back;
            ForegroundColor = fore;
            refresh = true;
        }

        public static void writeAt(int x, int y, string text, int foregroundcolor, int backgroundcolor) // skriv tekst i farver til position
        {
            ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkYellow };
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colors[foregroundcolor];
            Console.BackgroundColor = colors[backgroundcolor];
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;    //farver tilbage til default
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static bool hovedMenu = true;

        static void run() // denne metode kører den relevante opgave
        {
            Console.Clear();
            Console.CursorVisible = false;

            // kør den valgte metode
            switch(hovedMenuValg)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                    Console.WriteLine("7");
                    break;
                case 8:
                    Console.WriteLine("8");
                    break;
            }
        

            Console.Title = "P1 Opgaver";
            refresh = true;
            Console.ReadKey();
        }

        //Finder ud af hvilken menu item du er på
        public Boolean Input(bool exit)  // input til hovedmenu mm
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (hovedMenu == true)
                {
                    if (key.Key.Equals(ConsoleKey.UpArrow))
                    {
                        if (hovedMenuValg == 0)     // wraparound
                            hovedMenuValg = 15;
                        else
                            hovedMenuValg--;

                    }
                    if (key.Key.Equals(ConsoleKey.DownArrow))
                    {
                        if (hovedMenuValg == 15)    // wraparound
                            hovedMenuValg = 0;
                        else
                            hovedMenuValg++;

                    }
                    if (key.Key.Equals(ConsoleKey.Enter))
                    {
                        run();
                    }
                    if (key.Key.Equals(ConsoleKey.Escape))
                        return true;

                    refresh = true;

                }
            }
            else
                refresh = false;
            return false;
        }

        public void menu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.CursorVisible = false;
            if (refresh == true)
                Console.Clear(); // kan gøres smartere

            // Menugrafik og tekst 
            writeAt(5, 1, "                                        Nikolajs Investor Helper                                   ESC: Afslut", ForegroundColor, BackgroundColor);
            writeAt(5, 3, "                  Menu                ", 0, 2); writeAt(60, 3, "                        Widget                         ", ForegroundColor, BackgroundColor);
            writeAt(5, 30, "Naviger: ↑↓                          Vælg: Enter                                Credits til Anders for menuen  ", ForegroundColor, BackgroundColor);


            //Splitter hovedetmenuens emner op så de står ovenover hindanden, det gælder også for submenuen. (Tror jeg)
            for (int i = 0; i <= 15; i++)
                if (i == hovedMenuValg)
                {
                    if (hovedMenu == true)
                        writeAt(5, 5 + i, HovedMenuEmner[i], 0, 2);
                    else
                        writeAt(5, 5 + i, HovedMenuEmner[i], 2, 2);
                }
                else
                    writeAt(5, 5 + i, HovedMenuEmner[i], 2, 0);

        }
    }

    public class ConsoleSettings
    {
        private int userForColor;
        private int userBackColor;

        public void SetColor()
        {
            Console.WriteLine("Hvad farve skal foreground Consollen være?");
            userForColor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hvad farve skal background Consollen være?");
            userBackColor = Int32.Parse(Console.ReadLine());

            Menu mu = new Menu();
            mu.setConsoleSettings(userForColor, userBackColor);
        }

    }
}