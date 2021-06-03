using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InvestorHelperLibrary.ValutaAPI
{
    class APIconn
    {
        // sætter url api`en og installizerer en HTTPclient
        string url = "http://data.fixer.io/api/latest?access_key=cc1bfb32c70284eb460a1464d874de03";
        HttpClient client = new HttpClient();

        // Her henter jeg json ned i en string
        // Her bruger jeg et magisk produkt som (vil jeg tro) gør json stringen til diverse objecter
        // Som jeg så kan add til en List<Obejct> i en foreach
        // og så returner jeg den til CurrencyExchange
        public async Task<List<object>> GetJson()
        {
            var jsonBefore = await client.GetStringAsync(url);
            var getSet = JsonConvert.DeserializeObject<dynamic>(jsonBefore);
            var jquery = new List<object>();

            foreach (var i in getSet.rates)
            {
                jquery.Add(i);
            }

            return jquery;
        }
    }
}
