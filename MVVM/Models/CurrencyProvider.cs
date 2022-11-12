// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// 
// namespace MiniBank.MVVM.Models.Converter
// {
//     public class CurrencyProvider
//     {
//         public List<string> currencyList = new List<string>();
// 
//         public CurrencyProvider()
//         {
//             InitCurrencies();
//         }
// 
//         private void InitCurrencies()
//         {
//             var sqlConnection = new SqlConnection("Server=localhost;Database=TestCurrencyConverter;Trusted_Connection=True;TrustServerCertificate=true;");
//             var sql = "select Currency from Currencies";
//             var currencies = sqlConnection.Query<string>(sql);
//             foreach (var currency in currencies)
//             {
//                 currencyList.Add(currency);
//             }
//         }
//     }
// }
