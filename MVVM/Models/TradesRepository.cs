// using Java.Net;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// 
// namespace MiniBank.MVVM.Models.Converter
// {
//     public class TradesRepository
//     {
//         private readonly string _connectionString;
//         public TradesRepository(string connectionString)
//         {
//             if (string.IsNullOrWhiteSpace(connectionString))
//                 throw new ArgumentNullException(nameof(connectionString));
// 
//             _connectionString = connectionString;
//         }
// 
// 
//         public void Insert(Trade trade)
//         {
//             var sqlConnection = new SqlConnection(_connectionString);
//             var sql = "INSERT into [Trades] (Client, FromCurrency, ToCurrency, FromAmount, Rate, ConvertedAmount, Timestamp) values(@MyClient, @FromCurrency, @ToCurrency, @FromAmount, @Rate, @ConvertedAmount, @Timestamp) ";
//             sqlConnection.Execute(sql, new
//             {
//                 MyClient = trade.Client,
//                 trade.FromCurrency,
//                 trade.ToCurrency,
//                 trade.FromAmount,
//                 trade.Rate,
//                 trade.ConvertedAmount,
//                 TimeStamp = DateTime.UtcNow
//             });
//         }
//     }
// }
