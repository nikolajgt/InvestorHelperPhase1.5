using InvestorHelperLibrary;
using System;
using System.Threading;

namespace InvestorHelperStockPrice
{
    class Program
    {
        static bool exit;

        static void Main(string[] args)
        {
            Welcome();
            Widget wg = new Widget();
            Menu mu = new Menu();
            
            Console.SetWindowSize(120, 33);
            Console.Title = "Investor Helper";
            do
            {
                
                mu.menu();
                wg.ShowWidgetsFinance(5);
                exit = mu.Input(exit);

            }
            while (exit == false);
        }

        static void Welcome()
        {
            Menu.writeAt(45,15, "", 2, 0);
            string welcomeMessage = "Welcome to Investor Helper";

            for(int i = 0; i < welcomeMessage.Length; i++)
            {
                Console.Write(welcomeMessage[i]);
                Thread.Sleep(100);
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
