namespace BalanceSheetsApp.Web.Models
{
    public class BankViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FinancialClassViewModel> FinancialClasses { get; set; }
    }
}
