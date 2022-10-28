namespace BalanceSheetsApp.Web.Models
{
    public class FinancialClassViewModel
    {
        public string Name { get; set; }
        public decimal OpBalanceActSum { get => this.Accounts.Sum(a => a.OpeningBalance.Active); }
        public decimal OpBalancePasSum { get => this.Accounts.Sum(a => a.OpeningBalance.Passive); }
        public decimal DebitSum { get => this.Accounts.Sum(a => a.Debit); }
        public decimal CreditSum { get => this.Accounts.Sum(a => a.Credit); }
        public decimal ClBalanceActSum { get => this.Accounts.Sum(a => a.ClosingBalance.Active); }
        public decimal ClBalancePasSum { get => this.Accounts.Sum(a => a.ClosingBalance.Passive); }
        public ICollection<AccountViewModel> Accounts { get; set; }
    }
}
