namespace BalanceSheetsApp.Web.Models
{
    public class AccountViewModel
    {
        public int Number { get; set; }

        public BalanceViewModel OpeningBalance { get; set; }
        public BalanceViewModel ClosingBalance { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
