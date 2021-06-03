using InvestorHelperLibrary;
using System;

namespace InvestorHelperStockPrice
{
    class Program
    {
        static bool exit;

        static void Main(string[] args)
        {
            
            Widget wg = new Widget();
            Menu mu = new Menu();
            
            Console.SetWindowSize(120, 33);
            Console.Title = "Investor Helper";
            do
            {
                
                mu.menu();
                wg.ShowWidgetsFinance();
                exit = mu.Input(exit);

            }
            while (exit == false);
        }
    }
}
