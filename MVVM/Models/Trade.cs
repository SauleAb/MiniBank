using SQLite;

namespace MiniBank.MVVM.Models
{
    [Table("Trades")]
    public class Trade
    {
        public string Client { get; set; }

        public string FromCurrency { get; set; }

        public decimal FromAmount { get; set; }

        public string ToCurrency { get; set; }

        public decimal Rate { get; set; }

        public decimal ConvertedAmount { get; set; }
    }
}
