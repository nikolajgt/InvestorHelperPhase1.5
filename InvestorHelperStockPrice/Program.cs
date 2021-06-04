using InvestorHelperLibrary;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InvestorHelperStockPrice
{
    class Program
    {
        static bool exit;

        static void Main(string[] args)
        {   
            RunMenu();
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
            for (int t = 0; t < 3; t++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void RunMenu()
        {
            Welcome();
            Menu mu = new Menu();

            Console.SetWindowSize(120, 33);
            Console.Title = "Investor Helper";
            
            do
            {
                mu.menu();
                exit = mu.Input(exit);
            }
            while (exit == false);
        }

    }
}
