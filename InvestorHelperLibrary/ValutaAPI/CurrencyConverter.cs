using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvestorHelperLibrary.ValutaAPI
{
    class CurrencyConverter
    {

        List<string> stringlist = new List<string>();
        public async Task<double> RunMethods(string userInput, string userInput1, int userMoney)
        {
            // dynamic list = await RunList();

            foreach (var i in await RunList())
            {
                stringlist.Add(i);
            }
            var valutaOne = Parser(stringlist, userInput);
            var valutaOne1 = Parser(stringlist, userInput1);
            var answer = Calculator(valutaOne, valutaOne1, userMoney);
            return answer;

        }

        // Henter Currency rates obejct list fra GetCurrencyExchange
        // og laver dem om til generic list
        // Derefter display`er den listen i en Listbox
        // Den ene tager venstre den anden højre
        public async Task<List<string>> RunList()
        {
            List<string> returnList = new List<string>();
            APIconn apiconn = new APIconn();
            List<object> list = await apiconn.GetJson();
            foreach (var i in list)
            {
                returnList.Add(i.ToString());
            }
            return returnList;
        }


        // Her splitter jeg listen op så jeg kun får valutaen
        // Dernæst fjerner jeg mellemrum
        // og gør så decimal punktumet kommer frem via System.Globalization.CultureInfo.InvariantCulture
        // så nu er det et decimal jeg kan bruge til at regne på

        private double Parser(List<string> list, string userInput)
        {
            foreach (string i in list)
            {
                if (i.Contains(userInput))
                {
                    var splitted = i.Split(':');
                    var removeSpaces = string.Join("", splitted[1].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                    return double.Parse(removeSpaces, System.Globalization.CultureInfo.InvariantCulture);
                }
            }
            double placeholder = 0.00;
            return placeholder;
        }


        public double Calculator(double left, double right, int userMoney)
        {
            double answerReturn;

            var first = right * userMoney;
            answerReturn = first / left;

            return answerReturn;
        }
    }
}
