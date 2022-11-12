using MiniBank.Abstractions;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.MVVM.Models
{
    public class Conversion : TableData
    {
        [MaxLength(3)]
        public string FromCurrency { get; set; }
        [MaxLength(3)]
        public string ToCurrency { get; set; }
        public decimal Amount { get; set; }
        public DateTime ConversionDate { get; set; }
    }
}
