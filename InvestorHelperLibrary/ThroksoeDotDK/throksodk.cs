
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestorHelperLibrary.StockCal
{
    class throksodk
    {
        private const string server = "10.27.18.48";
        private const string port = "3306";
        private const string database = "throksoe_dkinvestorhelper";
        private const string password = "Hm4p5m59";
        private const string userID = "throksoe_dkinvestorhelper";
        private const string sslM = "none";

        private string connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, userID, password, database, sslM);

        private int earnedMoney = 0;
        private int taxMoney = 0;
        private int standalone = 0;


        private void MariaDBMoneyRead()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM InvestorHelperMoney;", connection))
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));
            }
        }

        public void MariaDBMoneyWrite()
        {
            try
            {
                string query = "insert into InvestorHelperMoney(EarnedMoney, TaxMoney, TimeStamp) values('" + earnedMoney + "','" + taxMoney + "','" + standalone + "');";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader myReader2;
                        myReader2 = command.ExecuteReader();
                        Console.WriteLine("Writing Complete");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}
