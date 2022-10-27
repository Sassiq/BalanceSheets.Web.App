namespace BalanceSheetsApp.Web.Models
{
    public class FinancialClassViewModel
    {
        public string Name { get; set; }
        public ICollection<AccountViewModel> Accounts { get; set; }
    }
}
